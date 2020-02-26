using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchestrA.GRAccess;

namespace SharpWindows
{
    public partial class WindowsMain : Form
    {
        GRAccessApp grAccess = new GRAccessAppClass();
        object SelectedItem;
        int SelectedItemIdnex = 0;
        string grNodeName = Environment.MachineName;
        string GalaxyName = "";
        string GalaxyUser = "";
        string GalaxyPass = "";
        string ExportFile = "\\export.csv";
        IGalaxies galaxies;
        IGalaxy galaxy;

        IgObjects IgObjs;
        IgObject IgObj;
        bool loggedIN = false; 


        public WindowsMain()
        {
            InitializeComponent();
        }
        private void WindowsMain_Load(object sender, EventArgs e)
        {
            txtGalaxyRep.Text = Environment.MachineName;
            lblStatus.Text = "Disconnected";
        }
        private void WindowsMain_Close(object sender, EventArgs e)
        {
            galaxy.Logout();
        }
        private void btnGetExistGalaxys_Click(object sender, EventArgs e)
        {
            list_galaxys.Items.Clear();
            galaxies = grAccess.QueryGalaxies(grNodeName);

            if (!grAccess.CommandResult.Successful)
            {
                list_galaxys.Items.Add("Error or not founded.");
            }
            else
            {
                foreach (IGalaxy galaxy in galaxies)
                {
                    list_galaxys.Items.Add(galaxy.Name);
                }
            }
        }
        private void list_galaxys_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGalaxyName.Text = list_galaxys.SelectedItem.ToString();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                galaxy = galaxies[txtGalaxyName.Text];
                GalaxyUser = txtUser.Text.ToString();
                galaxy.Login(GalaxyUser, GalaxyPass);
                if (galaxy.CommandResult.Successful)
                {
                    lblStatus.Text = "Connected";
                    lblStatus.ForeColor = Color.Green;
                    lblResMsgConnect.Text = "No Error";
                    loggedIN = true;
                }
                else
                {
                    lblStatus.Text = "Dicconnected.Try again.";
                    lblResMsgConnect.Text = "ID:" + galaxy.CommandResult.ID + "/nMessage:" + galaxy.CommandResult.CustomMessage.ToString();
                    loggedIN = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnGetInfo_Click(object sender, EventArgs e) // peredelatb pod svoi celi //
        {
            lstFounded.Items.Clear();
            try
            {
                IgObjs = galaxy.QueryObjects(EgObjectIsTemplateOrInstance.gObjectIsInstance, EConditionType.deploymentStatusIs, EDeploymentStatus.notDeployed, EMatch.MatchCondition);
                if (!(IgObjs == null))
                {
                    foreach (IgObject igobj in IgObjs)
                    {
                        lstFounded.Items.Add(igobj.HierarchicalName + "[" + igobj.Tagname + "]");
                        //lstFounded.Items.Add(igobj.Tagname);
                        //lstFounded.Items.Add(igobj.HierarchicalName);
                    }
                }
                else
                {
                    lstFounded.Items.Add("Nothing founded.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (loggedIN)
            {
                lblStatus.ForeColor = Color.Red;
                galaxy.Logout();
                if (galaxy.CommandResult.Successful)
                {
                    lblStatus.Text = "Dicconnected completed";
                    galaxies = grAccess.QueryGalaxies("");
                    loggedIN = false;
                }
                else
                {
                    lblStatus.Text = "Dicconnected failed";
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            galaxy.ExportAll(EExportType.exportAsCSV, ExportFile);
            if (!galaxy.CommandResult.Successful)
            {
                txtStatusResQ.Text = "Export failed";
            }
            else
            {
                txtStatusResQ.Text = "Export Complete.";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lstFounded.Items.Clear();
            object value = txtNameE.Text;

            try
            {
                IgObjs = galaxy.QueryObjects(EgObjectIsTemplateOrInstance.gObjectIsInstance, EConditionType.NameEquals, value, EMatch.MatchCondition);
                if (!(IgObjs == null))
                {
                    foreach (IgObject igobj in IgObjs)
                    {
                        //lstFounded.Items.Add(igobj.HierarchicalName + "[" + igobj.Tagname + "]");
                        lstFounded.Items.Add(igobj.Tagname);
                        //lstFounded.Items.Add(igobj.HierarchicalName);
                    }
                }
                else
                {
                    lstFounded.Items.Add("Nothing founded.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCOut_Click(object sender, EventArgs e)
        {
            try
            {
                IgObjs[SelectedItemIdnex].CheckOut();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCIn_Click(object sender, EventArgs e)
        {
            try
            {
                IgObjs[SelectedItemIdnex].CheckIn();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lstFounded_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = lstFounded.SelectedIndex;
            SelectedItemIdnex = lstFounded.SelectedIndex + 1;
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            IgObjs.Deploy(EActionForCurrentlyDeployedObjects.redeployOriginal, 
                ESkipIfCurrentlyUndeployed.dontSkipIfCurrentlyUndeployed, 
                EDeployOnScan.doDeployOnScan, 
                EForceOffScan.doForceOffScan, 
                false);
            txtStatusResQ.Text = "ID:" + IgObjs.CommandResults.Item[SelectedItemIdnex].ID.ToString() + " " + IgObjs.CommandResults.Item[SelectedItemIdnex].CustomMessage.ToString();
            
        }

        private void btnUnDep_Click(object sender, EventArgs e)
        {
            IgObjs.Undeploy(EForceOffScan.doForceOffScan, false);
            txtStatusResQ.Text = "ID:" + IgObjs.CommandResults.Item[SelectedItemIdnex].ID.ToString() + " " + IgObjs.CommandResults.Item[SelectedItemIdnex].CustomMessage.ToString();
            
        }
            }
}
