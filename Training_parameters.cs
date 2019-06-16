using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newapp
{
    public class Training_parameters
    {
        public int Patient_id { get; set; }
        public int pp_Load { get; set; }
        public int pp_Increase_of_Load { get; set; }
        public int pp_Training_Duration { get; set; }
        public int pp_Training_HR { get; set; }
        public int pp_Relative_Decrease_of_Load { get; set; }
        public int pp_Alarm_Limit { get; set; }
        public int pp_NIBP { get; set; }
        public int pi_Load { get; set; }
        public int pi_Increase_of_Load { get; set; }
        public int pi_Training_Duration { get; set; }
        public int pi_Training_HR { get; set; }
        public int pi_Relative_Drecrease_of_Load { get; set; }
        public int pi_Min_Time { get; set; }
        public int pi_Time_Lower_Level { get; set; }
        public int pi_Alarm_Limit { get; set; }
        public int pi_Load_limit { get; set; }
        public int pi_NIBP { get; set; }
        public int pr_Load { get; set; }
        public int pr_Increase_of_Load { get; set; }
        public int pr_Training_Duration { get; set; }
        public int pr_Training_HR { get; set; }
        public int pr_Relative_Decrase_of_Load { get; set; }
        public int pr_Time_for_Decrease { get; set; }
        public int pr_Increase { get; set; }
        public int pr_Alarm_Limit { get; set; }
        public int pr_Load_limit { get; set; }
        public int pr_NIBP { get; set; }
        public int lc_Load { get; set; }
        public int lc_Increase_of_load { get; set; }
        public int lc_Training_Duration { get; set; }
        public int lc_Training_Load { get; set; }
        public int lc_Relative_Decrease_of_Load { get; set; }
        public int lc_Alarm_Limit { get; set; }
        public int lc_Load_limit { get; set; }
        public int lc_NIBP { get; set; }
        public int li_Load { get; set; }
        public int li_Increase_of_load { get; set; }
        public int li_Training_Duration { get; set; }
        public int li_Upper_Level { get; set; }
        public int li_Relative_Decrease_of_Load { get; set; }
        public int li_Min_Time_Upper { get; set; }
        public int li_Min_Time_Lower { get; set; }
        public int li_Alarm_Limit { get; set; }
        public int li_Load_limit { get; set; }
        public int li_NIBP { get; set; }
        public int lr_Load { get; set; }
        public int lr_Increase_of_Load { get; set; }
        public int lr_Training_Duration { get; set; }
        public int lr_Upper_Level { get; set; }
        public int lr_Relative_Decrease_of_Load { get; set; }
        public int lr_Time_for_Decrease { get; set; }
        public int lr_Increase { get; set; }
        public int lr_Alarm_Limit { get; set; }
        public int lr_Load_limit { get; set; }
        public int lr_NIBP { get; set; }
        public int lf_Alarm_Limit { get; set; }
        public int lf_NIBP { get; set; }
        public int tt_Training_Duration { get; set; }
        public int tt_Alarm_Limit { get; set; }
        public int tt_NIBP { get; set; }
        public int tp_Training_Duration { get; set; }
        public int tp_HR_Min { get; set; }
        public int tp_HR_Max { get; set; }
        public int tp_Alarm_Limit { get; set; }
        public int tp_NIBP { get; set; }
        public int IPN_gender { get; set; }
        public int IPN_Option { get; set; }
        public int IPN_Protocol { get; set; }
        public int IPN_Wt { get; set; }
        public int IPN_Age { get; set; }
        public int IPN_Resting_HR { get; set; }
        public int IPN_Target_HR { get; set; }
        public int tt_Distance { get; set; }
        public int Free_def { get; set; }
        public double tt_w1_speed_m { get; set; }
        public double tt_w1_speed_km { get; set; }
        public double tt_w_slope { get; set; }
        public double tt_w2_speed_m { get; set; }
        public double tt_w2_speed_km { get; set; }
        public double tt_Increase_of_slope { get; set; }
        public double tt_tr_speed_m { get; set; }
        public double tt_tr_speed_km { get; set; }
        public double tt_tr_slope { get; set; }
        public double tp_w1_speed_m { get; set; }
        public double tp_w1_speed_km { get; set; }
        public double tp_w_slope { get; set; }
        public double tp_w2_speed_m { get; set; }
        public double tp_w2_speed_km { get; set; }
        public double tp_Increase_of_slope { get; set; }
        public double tp_tr_speed_m { get; set; }
        public double tp_tr_speed_km { get; set; }
        public int Test_type { get; set; }
        public int Fecg_Training_Duration { get; set; }
        public int Fecg_Alarm_Limit { get; set; }
        public int Fecg_NIBP { get; set; }
        public int Alarm_NIBP { get; set; }
        public int Alarm_SPO2 { get; set; }
        public ICollection<Archive_ids> Archive_Ids { get; set; }



    }
}
