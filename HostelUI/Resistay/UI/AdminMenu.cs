﻿using HostelDll.DlDb;
using HostelDll.DLInterfaces;
using HostelDll.Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistay.UI
{
    public partial class AdminMenu : Form
    {
        
        Boolean Labelvisible = true;
        Dwellers Dwellers;
        public AdminMenu()
        {
            InitializeComponent();
            
        }
        public AdminMenu(Dwellers dweller):this()
        {
            this.Dwellers = dweller;
            


        }

        private void Admin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Roombtn_Click(object sender, EventArgs e)
        {
            
            Rooms rooms = new Rooms();
            rooms.Show();
        }

         
         

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Labelvisible) 
            {
                ResuistayLabel.Visible = true;
                Labelvisible = false;
            }
            else
            {
                ResuistayLabel.Visible = false;
                Labelvisible = true;
            }
        }

        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            
            AllotmentofRoom Allotement = new AllotmentofRoom();
            Allotement.Show();

        }

        private void HostelBtn_Click(object sender, EventArgs e)
        {
              
            HostelManage hostelManage = new HostelManage();
             hostelManage.Show();
        }

         


         

        private void ResuistayLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RukesBtn_Click(object sender, EventArgs e)
        {
           
            Ruleform ruleform = new Ruleform();
            ruleform.Show();
        }

        private void addrtbtn_Click(object sender, EventArgs e)
        {
            
            AddRt addRt = new AddRt();
            addRt.Show();
        }

        private void Removalrtbtn_Click(object sender, EventArgs e)
        {
            
            RemoveRtandStudent removeRtandStudent = new RemoveRtandStudent();
            removeRtandStudent.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            
            LogOut logOutForm = new LogOut();
            logOutForm.LoggedOut += LogOutForm_LoggedOut;
            logOutForm.Show();
        }
        private void LogOutForm_LoggedOut(object sender, EventArgs e)
        {
            this.Hide(); 
            ((LogOut)sender).Close(); 
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProfileLabel_Click(object sender, EventArgs e)
        {
            ProfileLabel.Text = $"Hi {Dwellers.GetName()}! Welcome to your Profile";
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
