using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleServerQueuingSystem
{
    public partial class SingleServerQueuingSystem : Form
    {
        public SingleServerQueuingSystem()
        {
            InitializeComponent();
        }

        const int Q_LIMIT = 100;
        const int BUSY = 1;
        const int IDLE = 0;

        int next_event_type;
        int num_custs_delayed;
        int num_delays_required;
        int num_events;
        int num_in_q;
        int server_status;
        
        double area_num_in_q;
        double area_server_status;
        double mean_interarrival;
        double mean_service;
        double sim_time;
        double[] time_arrival = new double[Q_LIMIT+1];
        double time_last_event;
        double[] time_next_event = new double[3];
        double total_of_delays;

        private void initialize()
        {
            
            sim_time = 0.0;
            server_status = IDLE;
            num_in_q = 0;
            time_last_event = 0.0;
            num_custs_delayed = 0;
            total_of_delays = 0.0;
            area_num_in_q = 0.0;
            area_server_status = 0.0;

            time_next_event[1] = sim_time + expon(mean_interarrival);
            time_next_event[2] = 1.0e+30;
        }

        private void timing()
        {
            int i;
            double min_time_next_event = 1.0e+29;
            next_event_type = 0;

            for (i = 1; i <= num_events; ++i)
            {
                if (time_next_event[i] < min_time_next_event)
                {
                    min_time_next_event = time_next_event[i];
                    next_event_type = i;
                }
            }

            
            if (next_event_type == 0)
            {
                MessageBox.Show("Event list empty at time " + sim_time);
                Application.Exit();
            }

            sim_time = min_time_next_event;
        }

        private void arrive()
        {
            
            double delay;
            time_next_event[1] = sim_time + expon(mean_interarrival);

            if (server_status == BUSY)
            {
                ++num_in_q;

                if (num_in_q > Q_LIMIT)
                {
                    MessageBox.Show("Overflow of the array time_arrival at time "+sim_time);
                    Application.Exit();
                }

                time_arrival[num_in_q] = sim_time;

            }

            else
            {
                delay = 0.0;
                total_of_delays += delay;
                ++num_custs_delayed;
                server_status = BUSY;
                time_next_event[2] = sim_time + expon(mean_service);
            }
        }

        private void depart()
        {
            int i;
            double delay;

            if (num_in_q == 0)
            {
                server_status = IDLE;
                time_next_event[2] = 1.0e+30;
            }
            else
            {
                --num_in_q;
                delay = sim_time - time_arrival[1];
                total_of_delays += delay;
                ++num_custs_delayed;
                time_next_event[2] = sim_time + expon(mean_service);

                for (i = 1; i <= num_in_q; ++i)
                {
                    time_arrival[i] = time_arrival[i + 1];
                }
            }
        }

        private void report()
        {
            label_adiq.Text =("Average delay in queue  " + total_of_delays / num_custs_delayed+"  minutes");
            label_aniq.Text =("Average number in queue  " + area_num_in_q / sim_time);
            label_su.Text =("Server utilization  " + area_server_status / sim_time);
            label_tse.Text = ("Time simulation ended  " +sim_time+"  minutes");
        }

        private void update_time_avg_stats()
        {
            double time_since_last_event;
            time_since_last_event = sim_time - time_last_event;
            time_last_event = sim_time;
            area_num_in_q += num_in_q * time_since_last_event;
            area_server_status += server_status * time_since_last_event;
        }

        Random random = new Random();
        private double expon(double mean)
        {
            return -mean * Math.Log(random.NextDouble());
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            
            num_events = 2;
            mean_interarrival = Convert.ToDouble(textBox_MIT.Text);
            mean_service = Convert.ToDouble(textBox_MST.Text);
            num_delays_required = Convert.ToInt16(textBox_NOC.Text);

            initialize();

            while (num_custs_delayed < num_delays_required)
            {
                timing();
                update_time_avg_stats();

                switch (next_event_type)
                {
                    case 1:
                        arrive();
                        break;
                    case 2:
                        depart();
                        break;
                }
            }
            report();
        }
            
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_MIT.ResetText();
            textBox_MST.ResetText();
            textBox_NOC.ResetText();
            label_adiq.ResetText();
            label_aniq.ResetText();
            label_su.ResetText();
            label_tse.ResetText();
        }
    }
}
