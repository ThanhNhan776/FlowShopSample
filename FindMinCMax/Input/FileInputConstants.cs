﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinCMax.Input
{
    public class FileInputConstants
    {
        public const string StageAndJobSheet = "Stages and Jobs";
        public const string MachinesSheet = "Machines";
        public const string EligibilitySheet = "Eligibility";
        public const string ProcessingTimesSheet = "Processing times";
        public const string LagTimesSheet = "Lag times";
        public const string SetupTimesSheet = "Setup times";

        public const int EmptyCellValue = -1;

        public readonly WorkbookCell NumOfStagesCellIndex = new WorkbookCell { RowIndex = 1, ColIndex = 1 }; // Cell B2
        public readonly WorkbookCell NumOfJobsCellIndex = new WorkbookCell { RowIndex = 2, ColIndex = 1 }; // Cell B3
        public readonly WorkbookCell NumOfMachinesCellStart = new WorkbookCell { RowIndex = 2, ColIndex = 1 }; // Cell B3
        public readonly WorkbookCell EligibilityCellStart = new WorkbookCell { RowIndex = 2, ColIndex = 2 }; // Cell C3
        public readonly WorkbookCell ProcessingTimesCellStart = new WorkbookCell { RowIndex = 2, ColIndex = 3 }; // Cell D3
        public readonly WorkbookCell LagTimesCellStart = new WorkbookCell { RowIndex = 2, ColIndex = 3 }; // Cell D3
        public readonly WorkbookCell SetupTimesCellStart = new WorkbookCell { RowIndex = 2, ColIndex = 4 }; // Cell E3
    }

    public class WorkbookCell
    {
        public int RowIndex { get; set; }
        public int ColIndex { get; set; }

        /// <summary>
        /// Next cell index at next row, same column
        /// </summary>
        public void Next()
        {
            ++RowIndex;
        }
    }
}
