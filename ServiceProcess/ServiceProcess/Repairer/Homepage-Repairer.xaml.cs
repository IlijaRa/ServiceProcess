﻿using ServiceProcessLibrary.BusinessLogic;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ServiceProcess
{
    /// <summary>
    /// Interaction logic for Homepage_Repairer.xaml
    /// </summary>
    public partial class Homepage_Repairer : Window
    {
        public Homepage_Repairer()
        {
            InitializeComponent();
            tb_name.Text = CurrentRepairerInfo.Name;
            tb_surname.Text = CurrentRepairerInfo.Surname;
            tb_email.Text = CurrentRepairerInfo.EmailAddress;
            tb_longevity.Text = CurrentRepairerInfo.Longevity.ToString();
            tb_birthday.Text = CurrentRepairerInfo.Birthday.ToString("MM/dd/yyyy");
            tb_role.Text = "Repairer";

            var requests = NotificationCRUD.LoadRequests();
            List<Request> working_on_requests = new List<Request>();
            foreach (var request in requests)
            {
                if (request.RepairerId == CurrentRepairerInfo.Id)
                {
                    working_on_requests.Add(request);
                }
            }
            dg_working_on.ItemsSource = working_on_requests;
        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {
            Homepage_Repairer homepage = new Homepage_Repairer();
            homepage.Show();
            this.Hide();
        }

        private void Button_FindClient(object sender, RoutedEventArgs e)
        {
            FindClient_Repairer find = new FindClient_Repairer();
            find.Show();
            this.Hide();
        }

        private void Button_WriteReport(object sender, RoutedEventArgs e)
        {
            if (dg_working_on.SelectedItem != null)
            {
                var selected_request = (Request)dg_working_on.SelectedItem;
                WriteReport_Repairer report = new WriteReport_Repairer(selected_request);
                report.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a job that you are currently working on!");
            }
        }

        private void Button_GenerateBill(object sender, RoutedEventArgs e)
        {
            if(dg_working_on.SelectedItem != null)
            {
                var selected_request = (Request)dg_working_on.SelectedItem;
                BillGenerator_Repairer bill = new BillGenerator_Repairer(selected_request);
                bill.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a job that you are currently working on!");
            }
        }

        private void Button_SendNotification(object sender, RoutedEventArgs e)
        {
            if (dg_working_on.SelectedItem != null)
            {
                var selected_request = (Request)dg_working_on.SelectedItem;
                SendNotification_Repairer bill = new SendNotification_Repairer(selected_request);
                bill.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a job that you are currently working on!");
            }
        }
    }
}
