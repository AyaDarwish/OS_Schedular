using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Process_Scheduler
{
    public partial class Form1 : Form
    {
        DataTable T = new DataTable();
        public Form1()
        {
            InitializeComponent();
            T.Columns.Add("Process ID");
            T.Columns.Add("Arrival Time");
            T.Columns.Add("Burst Time");
            T.Columns.Add("Priority");
            processes_table.DataSource = T;
        }

        class Process
        {
            public string process_num;
            public double arrival_time, burst_time;
            public int Priority;
            public bool marked = false;

            public void set(string pnum, double arrival_time, double burst_time, int Priority = 0)
            {
                process_num = pnum;
                this.arrival_time = arrival_time;
                this.burst_time = burst_time;
                this.Priority = Priority; 
            }
        };

        static void Sort(List<Process> Processes, int no_Process)
        {
            double temp1;
            string temp2;

            for (int i = 0; i < no_Process - 1; i++)
            {
                for (int j = i + 1; j < no_Process; j++)
                {
                    if (Processes[i].burst_time > Processes[j].burst_time)
                    {
                        temp1 = Processes[i].burst_time;
                        Processes[i].burst_time = Processes[j].burst_time;
                        Processes[j].burst_time = temp1;

                        temp2 = Processes[i].process_num;
                        Processes[i].process_num = Processes[j].process_num;
                        Processes[j].process_num = temp2;

                        temp1 = Processes[i].arrival_time;
                        Processes[i].arrival_time = Processes[j].arrival_time;
                        Processes[j].arrival_time = temp1;
                    }

                    else if (Processes[i].burst_time == Processes[j].burst_time)
                    {
                        if (Processes[i].arrival_time > Processes[j].arrival_time)
                        {
                            temp1 = Processes[i].burst_time;
                            Processes[i].burst_time = Processes[j].burst_time;
                            Processes[j].burst_time = temp1;

                            temp2 = Processes[i].process_num;
                            Processes[i].process_num = Processes[j].process_num;
                            Processes[j].process_num = temp2;

                            temp1 = Processes[i].arrival_time;
                            Processes[i].arrival_time = Processes[j].arrival_time;
                            Processes[j].arrival_time = temp1;

                        }
                    }
                }
            }
        }

        static void Sort_Priority(List<Process> Processes, int no_Process)
        {
            double temp1;
            string temp2;


            for (int i = 0; i < no_Process - 1; i++)
            {
                for (int j = i + 1; j < no_Process; j++)
                {
                    if (Processes[i].Priority > Processes[j].Priority)
                    {
                        temp1 = Processes[i].Priority;
                        Processes[i].Priority = Processes[j].Priority;
                        Processes[j].Priority = (int)temp1;

                        temp2 = Processes[i].process_num;
                        Processes[i].process_num = Processes[j].process_num;
                        Processes[j].process_num = temp2;

                        temp1 = Processes[i].arrival_time;
                        Processes[i].arrival_time = Processes[j].arrival_time;
                        Processes[j].arrival_time = temp1;


                        temp1 = Processes[i].burst_time;
                        Processes[i].burst_time = Processes[j].burst_time;
                        Processes[j].burst_time = temp1;
                    }
                }
            }
        }

        static void Sort_Arrival(List<Process> Processes, int no_Process)
        {
            double temp1;
            string temp2;
            for (int i = 0; i < no_Process - 1; i++)
            {
                for (int j = i + 1; j < no_Process; j++)
                {
                    if (Processes[i].arrival_time > Processes[j].arrival_time)
                    {
                        temp1 = Processes[i].arrival_time;
                        Processes[i].arrival_time = Processes[j].arrival_time;
                        Processes[j].arrival_time = (int)temp1;

                        temp2 = Processes[i].process_num;
                        Processes[i].process_num = Processes[j].process_num;
                        Processes[j].process_num = temp2;

                        temp1 = Processes[i].burst_time;
                        Processes[i].burst_time = Processes[j].burst_time;
                        Processes[j].burst_time = temp1;
                    }
                }
            }
        }
        static List<Process> schedule = new List<Process>();
        /*/////////////////////////////////////// FCFS //////////////////////////////////////////////*/
        static double FCFS_Schedule(List<Process> Processes, int no_Process)
        {
            double waiting_Time = 0 , current_time = 0;

            Sort_Arrival(Processes, no_Process);
            for (int i = 0; i < no_Process; i++)
            {
                Process temp_set = new Process();
                temp_set.set(Processes[i].process_num, current_time, Processes[i].burst_time);
                schedule.Add(temp_set);
                if (i!=0)
                    waiting_Time += current_time - Processes[i].arrival_time;
                current_time += Processes[i].burst_time;
            }
            return waiting_Time / no_Process;
        }
        /*//////////////////////////// Shortest Job First (Non Preemptive) ///////////////////////////////////*/
        static double SJFNP_Schedule(List<Process> Processes, int no_Process) //schedule
        {
            double waiting_Time = 0;
            double current_Time = 0;

            Sort(Processes, no_Process);

            for (int j = 0; j < no_Process; j++)
            {
                int i = 0;
                while (current_Time < Processes[i].arrival_time)
                {
                    i++;
                }

                Process temp_set = new Process();
                temp_set.set(Processes[i].process_num, current_Time, Processes[i].burst_time);
                schedule.Add(temp_set);

                waiting_Time += current_Time - Processes[i].arrival_time;            
                current_Time += Processes[i].burst_time;
                Processes.RemoveAt(i);
            }
            return waiting_Time / no_Process;
        }

        /*///////////////////////////////////////// Shortest Job First (Preemptive) ///////////////////////////////////////////*/
        static double SJFP_Schedule(List<Process> Processes, int no_Process)
        {
            List<double> Waiting_Time = new List<double>();
            double waiting_Time = 0;
            double current_Time = 0;
            int j = 0;

            while (Processes.Any())
            {
                Sort(Processes, Processes.Count);
                int i = 0;
                while (current_Time < Processes[i].arrival_time)
                    i++;

                if (j == 0)
                    Waiting_Time.Add(0);

                else
                {
                    double temp = current_Time;
                    Waiting_Time.Add(temp - Processes[i].arrival_time);
                    waiting_Time += Waiting_Time[j];
                }
                Process temp_set = new Process();
                double pre_current_time = current_Time;
                double burst = Processes[i].burst_time;
                bool suspend = false;
                do
                {
                    current_Time++;
                    burst--;
                    for (int k = 0; k < i; k++)
                    {
                        if ((current_Time >= Processes[k].arrival_time) && (burst > Processes[k].burst_time))
                            suspend = true;
                    }
                } while (!suspend && burst != 0);

                if (suspend)
                {
                    temp_set.set(Processes[i].process_num,pre_current_time, (current_Time - pre_current_time), Processes[i].Priority); //gannt chart
                    schedule.Add(temp_set);

                    if (Processes[i].burst_time - (current_Time - pre_current_time) == 0)
                        Processes.RemoveAt(i);

                    else
                    {
                        Processes[i].arrival_time = current_Time ;
                        Processes[i].burst_time -= current_Time - pre_current_time;
                    }

                }

                else
                {
                    temp_set.set(Processes[i].process_num, pre_current_time, Processes[i].burst_time, Processes[i].Priority);//gannt chart
                    schedule.Add(temp_set);
                    Processes.RemoveAt(i);
                }
                j++;
            }
            return waiting_Time / no_Process;
        }
/*///////////////////////////////////////// Priority (Non Preemptive) ///////////////////////////////////////////////////*/
        static double PriorityNP_Schedule(List<Process> Processes, int no_Process)
        {
            double waiting_Time = 0;
            double current_Time = 0;

            Sort_Priority(Processes, no_Process);

            for (int j = 0; j < no_Process; j++)
            {
                int i = 0;
                while (current_Time < Processes[i].arrival_time)
                    i++;

                Process temp_set = new Process();
                temp_set.set(Processes[i].process_num, current_Time, Processes[i].burst_time);
                schedule.Add(temp_set);

                waiting_Time += current_Time - Processes[i].arrival_time;
                current_Time += Processes[i].burst_time;
                Processes.RemoveAt(i);
            }
            return waiting_Time / no_Process;
        }
/*/////////////////////////////////////// Priority (Preemptive) ///////////////////////////////////////////////*/
        static double PriorityP_Schedule(List<Process> Processes, int no_Process)
        {
            List<double> Waiting_Time = new List<double>();
            double waiting_Time = 0;
            double current_Time = 0;
            int j = 0;

            Sort_Priority(Processes, Processes.Count);
            while (Processes.Any())
            {           
                int i = 0;
                while (current_Time < Processes[i].arrival_time)
                    i++;

                if (j == 0)
                    Waiting_Time.Add(0);

                else
                {
                    Waiting_Time.Add(current_Time - Processes[i].arrival_time);
                    waiting_Time += Waiting_Time[j];
                }

                Process temp_set = new Process();

                double pre_current_time = current_Time;
                double burst = Processes[i].burst_time;
                bool suspend = false;
                do
                {
                    current_Time++;
                    burst--;
                    for (int k = 0; k < i; k++)
                    {
                        if (current_Time >= Processes[k].arrival_time)
                            suspend = true;
                    }
                } while (!suspend && burst != 0);

                if (suspend)
                {
                    temp_set.set(Processes[i].process_num, pre_current_time, current_Time - pre_current_time, Processes[i].Priority); //gannt chart
                    schedule.Add(temp_set);

                    if (Processes[i].burst_time - (current_Time - pre_current_time) == 0)
                        Processes.RemoveAt(i);

                    else
                    {
                        Processes[i].arrival_time = current_Time ;
                        Processes[i].burst_time -= current_Time - pre_current_time;
                    }

                }              
                else
                {
                    temp_set.set(Processes[i].process_num,pre_current_time, Processes[i].burst_time, Processes[i].Priority);//gannt chart
                    schedule.Add(temp_set);
                    Processes.RemoveAt(i);
                }
                j++;
            }
            return waiting_Time / no_Process;
        }
/*////////////////////////////////////////////// Round Robin /////////////////////////////////////////////////////*/
        static double RR_Schedule(List<Process> Processes, int no_Process, int Quantum)
        {
            List<double> Waiting_Time = new List<double>();
            List<Process> readyqueue = new List<Process>();
            double waiting_Time = 0;
            double current_time = 0;
            double pre_Burst_time = 0;
            int j = 0;

            Sort_Arrival(Processes, no_Process);
            for (int i = 0; i < Processes.Count(); i++)
            {
                bool flag = false;
                if (Processes[i].arrival_time == 0)
                {
                    readyqueue.Add(Processes[i]);
                    Processes.RemoveAt(i);
                    i = i - 1;
                    flag = true;
                }

                if (!flag)
                    break;
            }

            while (readyqueue.Any())
            {
                for (int i = 0; i < readyqueue.Count();i++)
                {
                    if (j == 0)
                        Waiting_Time.Add(0);

                    else
                    {
                        //double temp = Waiting_Time[j - 1] + schedule[j - 1].burst_time + schedule[j - 1].arrival_time;
                        Waiting_Time.Add(current_time - readyqueue[i].arrival_time);
                        waiting_Time += Waiting_Time[j];
                    }

                    if (readyqueue[i].burst_time <= Quantum)
                    {
                        pre_Burst_time = readyqueue[i].burst_time;
                        Process temp_set = new Process ();
                        temp_set.set(readyqueue[i].process_num, current_time, pre_Burst_time);
                        schedule.Add(temp_set);
                        readyqueue.RemoveAt(i);
                        i--;
                        current_time += pre_Burst_time;

                    }
                    else
                    {
                        pre_Burst_time = Quantum;
                        Process temp_set = new Process();
                        temp_set.set(readyqueue[i].process_num, current_time, pre_Burst_time);
                        schedule.Add(temp_set);
                        current_time += pre_Burst_time;
                        readyqueue[i].arrival_time = current_time;
                        readyqueue[i].burst_time -= pre_Burst_time;
                        readyqueue[i].marked = true;
                    }
                    j++;
                    if (Processes.Any())
                    {
                        if (Processes[0].arrival_time <= current_time)
                        {
                            if (i < readyqueue.Count - 1 && readyqueue[i + 1].marked == true)
                            {
                                readyqueue.Insert(i + 1, Processes[0]);
                                Processes.RemoveAt(0);
                            }
                            else
                            {
                                readyqueue.Insert(readyqueue.Count, Processes[0]);
                                Processes.RemoveAt(0);
                            }
                        }
                        
                    }
                }
            }
            return waiting_Time / no_Process;
        }

        private void FCFS_Button_CheckedChanged(object sender, EventArgs e)
        {
            process_id.Enabled = true;
            arrival_time.Enabled = true;
            burst_time.Enabled = true;
            priority.Enabled = false;
            quantum.Enabled = false;
            ADD_Button.Enabled = true;
        }

        private void JSFP_Button_CheckedChanged(object sender, EventArgs e)
        {
            process_id.Enabled = true;
            arrival_time.Enabled = true;
            burst_time.Enabled = true;
            priority.Enabled = false;
            quantum.Enabled = false;
            ADD_Button.Enabled = true;
        }

        private void JSFNP_Button_CheckedChanged(object sender, EventArgs e)
        {
            process_id.Enabled = true;
            arrival_time.Enabled = true;
            burst_time.Enabled = true;
            priority.Enabled = false;
            quantum.Enabled = false;
            ADD_Button.Enabled = true;

        }

        private void PriorityP_Button_CheckedChanged(object sender, EventArgs e)
        {
            process_id.Enabled = true;
            arrival_time.Enabled = true;
            burst_time.Enabled = true;
            priority.Enabled = true;
            quantum.Enabled = false;
            ADD_Button.Enabled = true;
        }

        private void PriorityNP_Button_CheckedChanged(object sender, EventArgs e)
        {
            process_id.Enabled = true;
            arrival_time.Enabled = true;
            burst_time.Enabled = true;
            priority.Enabled = true;
            quantum.Enabled = false;
            ADD_Button.Enabled = true;
        }

        private void RR_Button_CheckedChanged(object sender, EventArgs e)
        {
            process_id.Enabled = true;
            arrival_time.Enabled = true;
            burst_time.Enabled = true;
            priority.Enabled =false;
            quantum.Enabled = true;
            ADD_Button.Enabled = true;
        }

        List<Process> Processes = new List<Process>();
        int counter = 0;
        private void ADD_Button_Click(object sender, EventArgs e)
        {
            counter++;
        
            Process p = new Process();
            string process_name = "P" + process_id.Text;

            if (PriorityNP_Button.Checked || PriorityP_Button.Checked)
                p.set(process_name, Convert.ToDouble(arrival_time.Text), Convert.ToDouble(burst_time.Text),Convert.ToInt32(priority.Text));
            else
                p.set(process_name, Convert.ToDouble(arrival_time.Text), Convert.ToDouble(burst_time.Text));

            Processes.Add(p);
            T.Rows.Add(process_id.Text, arrival_time.Text, burst_time.Text,priority.Text);
            processes_table.DataSource = T;
            process_id.Text = "";
            arrival_time.Text = "";
            burst_time.Text = "";
            priority.Text = "";
            if (counter == Convert.ToInt32(processes_no.Text))
            {
                process_id.Enabled = false;
                arrival_time.Enabled = false;
                burst_time.Enabled = false;
                priority.Enabled = false;
                quantum.Enabled = false;
                ADD_Button.Enabled = false;
                Run_Button.Enabled = true;
                Restart_Button.Enabled = true;
            }
            FCFS_Button.Enabled = false;
            SJFNP_Button.Enabled = false;
            SJFP_Button.Enabled = false;
            PriorityNP_Button.Enabled = false;
            PriorityP_Button.Enabled = false;
            RR_Button.Enabled = false;
            processes_no.Enabled = false;
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            waitingtime.Visible = true;
            int Process_num = Convert.ToInt32(processes_no.Text);

            DataTable chart = new DataTable();
            chart.Columns.Add("Start");
            chart.Columns.Add("End");
            chart.Columns.Add("High");
            chart.Columns.Add("Low");
            chart.Columns.Add("Name");
            
            if (FCFS_Button.Checked)
                waitingtime.Text = Convert.ToString(FCFS_Schedule(Processes, Process_num));

            else if (SJFNP_Button.Checked)
                waitingtime.Text = Convert.ToString(SJFNP_Schedule(Processes, Process_num));

            else if (SJFP_Button.Checked)
                waitingtime.Text = Convert.ToString(SJFP_Schedule(Processes, Process_num));

            else if (PriorityP_Button.Checked)
                waitingtime.Text = Convert.ToString(PriorityP_Schedule(Processes, Process_num));

            else if (PriorityNP_Button.Checked)
                waitingtime.Text = Convert.ToString(PriorityNP_Schedule(Processes, Process_num));

            else if (RR_Button.Checked)
                waitingtime.Text = Convert.ToString(RR_Schedule(Processes, Process_num, Convert.ToInt32(quantum.Text)));

            for (int i = 0; i < schedule.Count; i++)
                    chart.Rows.Add(schedule[i].arrival_time, schedule[i].arrival_time + schedule[i].burst_time, 3, 1, schedule[i].process_num);

            ganttchart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            ganttchart.Series["CPU Schedule"].XValueMember = "Name";
            ganttchart.Series["CPU Schedule"].YValueMembers = "Start,End,High,Low";
            ganttchart.Series["CPU Schedule"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            ganttchart.Series["CPU Schedule"]["ShowOpenClose"] = "Both";
            ganttchart.DataManipulator.IsStartFromFirst = true;
            ganttchart.DataSource = chart;
            ganttchart.DataBind();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void ganttchart_Click(object sender, EventArgs e)
        {

        }
    }
}
