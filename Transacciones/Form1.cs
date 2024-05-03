using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transacciones
{
    public partial class PanelPadre1 : Form
    {
        public PanelPadre1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelDepositarSubMenu.Visible = false;
            panelTransferirSubMenu.Visible = false;
            panelHistorialSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDepositarSubMenu.Visible == true)
                panelDepositarSubMenu.Visible = false;
            if(panelTransferirSubMenu.Visible == true)
                panelTransferirSubMenu.Visible = false;
            if (panelHistorialSubMenu.Visible == true)
                panelHistorialSubMenu.Visible =false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void PanelPadre1_Load(object sender, EventArgs e)
        {   
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            showSubmenu(panelDepositarSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {

        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTransferirSubMenu);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            showSubmenu(panelHistorialSubMenu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
