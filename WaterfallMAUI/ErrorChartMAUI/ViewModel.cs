using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorChartMAUI
{
    
    public class ViewModel
    {
        public ViewModel()

        {

            this.RevenueDetails = new ObservableCollection<WaterfallModel>();



            RevenueDetails.Add(new WaterfallModel() { Category = "Sales", Value = 165 });

            RevenueDetails.Add(new WaterfallModel() { Category = "Staff", Value = -47 });

            RevenueDetails.Add(new WaterfallModel() { Category = "Balance", Value = -58, IsSummary = true });

            RevenueDetails.Add(new WaterfallModel() { Category = "Others", Value = 15 });

            RevenueDetails.Add(new WaterfallModel() { Category = "Tax", Value = -20 });

            RevenueDetails.Add(new WaterfallModel() { Category = "Profit", Value = 45, IsSummary = true });

            RevenueDetails.Add(new WaterfallModel() { Category = "Intentory", Value = -10 });

            RevenueDetails.Add(new WaterfallModel() { Category = "Marketing", Value = -25 });

            RevenueDetails.Add(new WaterfallModel() { Category = " Net Income", Value = 25, IsSummary = true });

        }
        public ObservableCollection<WaterfallModel> RevenueDetails { get; set; }
    }
}

