using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace Car_Spare_Parts_company
{
    public partial class Chat : Form
    {
        HubConnection hub;
        public Chat()
        {
            InitializeComponent();
            
            hub = new HubConnectionBuilder().WithUrl("https://localhost:7125/").Build();
            hub.Closed += HubConnection_closed;
        }

        private async Task HubConnection_closed(Exception arg)
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await hub.StartAsync();
        }

        private async void Chat_Load(object sender, EventArgs e)
        {
            hub.On<string, string>("ReceiveMessage", (user, message) => {

                var newMessage = $"{user}:{message}";
                listBox1.Items.Add(newMessage);
            });

            try
            {
                await hub.StartAsync();
                listBox1.Items.Add("Connection Started");
            }
            catch (Exception ex)
            {

                listBox1.Items.Add(ex.Message);

            }

        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                await hub.InvokeAsync("SendMessage", guna2TextBox1.Text, guna2TextBox4.Text);
            }
            catch (Exception ex)
            {

                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
