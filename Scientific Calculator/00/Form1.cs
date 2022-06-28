using System;
using System.Linq;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class frmMainWindow : Form
    {
        bool blNewEntry = false;
        string strPreviousOperator = string.Empty, strStatisticsOperation = string.Empty;
        double dblResult = 0, dblOperand = 0, dblMemory = 0, dblStatisticsResult = 0;
        int inConversionForTrigonometry = 1, inConversionForNonDecimal = 1, inInfinityException = 0, inEquals = 0, inCurrentBase = 10, inParanthesisCount = 0, inCurrentBaseOfMemory = 10;
        frmStatisticsForm obj;
        public frmMainWindow()
        {
            InitializeComponent();
            AdditionalInitialisation();
        }
        private void DisplayProperConversionSystemAndDisables(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                gbConversions.Controls.Clear();
                gbConversions.Controls.AddRange(((RadioButton)sender == rbtDecimalNumberSystem) ? ctrControlsForDecimalsSystem : ctrControlsForNonDecimalsSystem);
                if (((RadioButton)sender) == rbtDecimalNumberSystem)
                {
                    DisableOrEnableNumbers(true, true);
                    DisableOrEnableAlpbets(false);
                    DisableOrEnableForDecimalSystem(true);
                    txtResult.Text = ConvertNumberSystem(inCurrentBase, txtResult.Text, 10);
                    inCurrentBase = 10;
                }
                if (((RadioButton)sender) == rbtOctalNumberSystem)
                {
                    DisableOrEnableAlpbets(false);
                    DisableOrEnableForDecimalSystem(false);
                    DisableOrEnableNumbers(true, false);
                    txtResult.Text = ConvertNumberSystem(inCurrentBase, txtResult.Text, 8);
                    inCurrentBase = 8;
                }
                if (((RadioButton)sender) == rbtHexagonalNumberSystem)
                {
                    DisableOrEnableForDecimalSystem(false);
                    DisableOrEnableNumbers(true, true);
                    DisableOrEnableAlpbets(true);
                    txtResult.Text = ConvertNumberSystem(inCurrentBase, txtResult.Text, 16);
                    inCurrentBase = 16;
                }
                if (((RadioButton)sender) == rbtBinaryNumberSystem)
                {
                    DisableOrEnableAlpbets(false);
                    DisableOrEnableForDecimalSystem(false);
                    DisableOrEnableNumbers(false, false);
                    txtResult.Text = ConvertNumberSystem(inCurrentBase, txtResult.Text, 2);
                    inCurrentBase = 2;
                }
                blNewEntry = true;
            }
        }
        string ConvertNumberSystem(int inFromBase, string strOperand, int inToBase)
        {
            if (inFromBase != 10)
                strOperand = Convert.ToInt64(strOperand, inFromBase).ToString();
            if (inToBase != 10)
                strOperand = Convert.ToString((long)double.Parse(strOperand), inToBase).ToUpper();
            if (inFromBase == 10 && inToBase == 10) strOperand = ((int)double.Parse(strOperand)).ToString();
            return strOperand;
        }
        void DisableOrEnableAlpbets(bool blStatus)
        {
            btnAlphabetA.Enabled = btnAlphabetB.Enabled = btnAlphabetC.Enabled = btnAlphabetD.Enabled = btnAlphabetE.Enabled = btnAlphabetF.Enabled = blStatus;
        }
        void DisableOrEnableNumbers(bool blBinaryStatus, bool blOctalStatus)
        {
            btnNumber2.Enabled = btnNumber3.Enabled = btnNumber4.Enabled = btnNumber5.Enabled = btnNumber6.Enabled = btnNumber7.Enabled = blBinaryStatus;
            btnNumber8.Enabled = btnNumber9.Enabled = blOctalStatus;
        }
        void DisableOrEnableForDecimalSystem(bool blStatus)
        {
            btnOnAndOffScientificNotation.Enabled = btnDegreeMinuteSecondFormat.Enabled = btnSin.Enabled = btnCos.Enabled = btnTan.Enabled = btnScientificNotation.Enabled = btnPiConstant.Enabled = blStatus;
        }
        private void UpdateOperand(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if (blNewEntry)
                {
                    txtResult.Text = "0";
                    blNewEntry = false;
                }
                if (inEquals == 1)
                {
                    strPreviousOperator = string.Empty;
                    dblResult = 0;
                }
                if (txtResult.Text.Contains("E+0"))
                    txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1) + ((Button)sender).Text;
                else if (sender as Button == btnDecimalPoint && inCurrentBase != 10) { }
                else if (!(txtResult.Text == "0" && (Button)sender == btnNumber0) && !(((Button)sender) == btnDecimalPoint && txtResult.Text.Contains(".")))
                    txtResult.Text = (txtResult.Text == "0" && ((Button)sender) == btnDecimalPoint) ? "0." : ((txtResult.Text == "0") ? ((Button)sender).Text : txtResult.Text + ((Button)sender).Text);
            }
        }
        private void ChangeSign(object sender, EventArgs e)
        {
            txtResult.Text = (double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)) * -1).ToString();
            if (inCurrentBase != 10) txtResult.Text = ConvertNumberSystem(10, txtResult.Text, inCurrentBase);
        }
        private void RemoveLastDigit(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("E"))
            {
                string strlastThreeCharacters = txtResult.Text.Substring(txtResult.Text.Length - 3, 3);
                if (strlastThreeCharacters[0] != 'E') txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
                else if (strlastThreeCharacters[2] == '0') txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 3);
                else txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1) + "0";
            }
            else if (txtResult.Text != "0") txtResult.Text = ((txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1)) == "" | txtResult.Text == "-") ? "0" : txtResult.Text;                
        }
        private void SetConversionStatusForTrigonometry(object sender, EventArgs e)
        {
            inConversionForTrigonometry = ((RadioButton)sender == rbtDegree) ? 1 : (((RadioButton)sender == rbtRadians) ? 2 : 3);
        }
        private void ChangeConversionStatusForNonDecimal(object sender, EventArgs e)
        {
            inConversionForNonDecimal = (((RadioButton)sender) == rbtQword) ? 1 : ((((RadioButton)sender) == rbtDword) ? 2 : ((((RadioButton)sender) == rbtWord) ? 3 : 4));
        }
        private void OperatorFound(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                inEquals = 0;
                if (strPreviousOperator == string.Empty)
                {
                    strPreviousOperator = ((Button)sender).Text;
                    if (txtResult.Text.Contains("(") == false)
                        dblResult = (inCurrentBase == 10) ? double.Parse(txtResult.Text) : int.Parse(ConvertNumberSystem(inCurrentBase, txtResult.Text, 10));
                }
                else if (blNewEntry)
                    strPreviousOperator = ((Button)sender).Text;
                else
                {
                    Operate(dblResult, strPreviousOperator, ((inCurrentBase == 10) ? double.Parse(txtResult.Text) : int.Parse(ConvertNumberSystem(inCurrentBase, txtResult.Text, 10))));
                    strPreviousOperator = ((Button)sender).Text;
                }
                blNewEntry = true;
            }
        }
        void Operate(double dblPreviousResult, string strPreviousOperator, double dblOperand)
        {
            switch (strPreviousOperator)
            {
                case "+":
                    txtResult.Text = (dblResult = (dblPreviousResult + dblOperand)).ToString();
                    break;
                case "-":
                    txtResult.Text = (dblResult = (dblPreviousResult - dblOperand)).ToString();
                    break;
                case "*":
                    txtResult.Text = (dblResult = (dblPreviousResult * dblOperand)).ToString();
                    break;
                case "/":
                    txtResult.Text = (dblResult = (dblPreviousResult / dblOperand)).ToString();
                    if (txtResult.Text == "Infinity") { txtResult.Text = "Cannot divide by zero"; inInfinityException = 1; }
                    break;
                case "Mod":
                    txtResult.Text = (dblResult = (dblPreviousResult % dblOperand)).ToString();
                    break;
                case "And":
                    txtResult.Text = ((int)dblResult & (int)(dblOperand)).ToString();
                    break;
                case "Or":
                    txtResult.Text = ((int)dblResult | (int)(dblOperand)).ToString();
                    break;
                case "Xor":
                    txtResult.Text = ((int)dblResult ^ (int)(dblOperand)).ToString();
                    break;
                case "Lsh":
                    txtResult.Text = ((cbxSetInveseFunctions.Checked == false) ? ((int)dblResult << (int)dblOperand) : ((int)dblResult >> (int)dblOperand)).ToString();
                    break;
                case "x^y":
                    if(cbxSetInveseFunctions.Checked)
                        txtResult.Text = (Math.Pow(dblResult, 1.0/dblOperand)).ToString();
                    else
                    txtResult.Text = (Math.Pow(dblResult, dblOperand)).ToString();
                    break;
            }
            if (inCurrentBase != 10) txtResult.Text = ConvertNumberSystem(10, txtResult.Text, inCurrentBase);
        }
        private void Equals(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if (inEquals == 0)
                {
                    dblOperand = Convert.ToDouble((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10));
                    inEquals++;
                }
                Operate(dblResult, strPreviousOperator, dblOperand);
                blNewEntry = true;
            }
        }
        private void OneByNumber(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
                Operate(1, "/", double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)));
            blNewEntry = true;
        }
        private void ClearExceptMemory(object sender, EventArgs e)
        {
            inParanthesisCount = inInfinityException = 0;
            dblOperand = dblResult = inEquals = 0; txtResult.Text = "0";
            blNewEntry = false;
            txtParanthesisIndicator.Text = "";
            strPreviousOperator = string.Empty;
        }
        private void ClearOperator(object sender, EventArgs e)
        {
            inInfinityException = 0;
            txtResult.Text = "0";
        }
        private void MemmoryOperations(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                blNewEntry = true;
                if ((Button)sender == btnMemorySet && double.Parse(txtResult.Text) != 0)
                {
                    txtMemoryIndicator.Text = "M";
                    dblMemory = double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10));
                }
                else if ((Button)sender == btnMemoryAdd && double.Parse(txtResult.Text) != 0)
                {
                    txtMemoryIndicator.Text = "M";
                    dblMemory = dblMemory + ((inCurrentBase == 10) ? double.Parse(txtResult.Text) : double.Parse(ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)));
                }
                else if ((Button)sender == btnMemoryRead)
                    txtResult.Text = (inCurrentBase == 10) ? dblMemory.ToString() : ConvertNumberSystem(10, dblMemory.ToString(), inCurrentBase);
                else if ((Button)sender == btnMemoryClear)
                {
                    dblMemory = 0;
                    inCurrentBaseOfMemory = 10;
                    txtMemoryIndicator.Text = "";
                }
                inCurrentBaseOfMemory = inCurrentBase;
            }
        }
        private void SetPiValue(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
                txtResult.Text = (Math.PI).ToString();
            blNewEntry = true;
        }
        private void BitwiseInverse(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
                txtResult.Text = ConvertNumberSystem(10, (~(int)((inCurrentBase == 10) ? double.Parse(txtResult.Text) : Convert.ToDouble(ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)))).ToString(), inCurrentBase);
            blNewEntry = true;
        }
        private void ShowIntegerOrfractionalPortion(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
                txtResult.Text = ConvertNumberSystem(10, ((cbxSetInveseFunctions.Checked == false) ? (int)((inCurrentBase == 10) ? double.Parse(txtResult.Text) : Convert.ToDouble(ConvertNumberSystem(inCurrentBase, txtResult.Text, 10))) : ((txtResult.Text.Contains(".") ? (int.Parse(txtResult.Text.Remove(0, (txtResult.Text.IndexOf('.') + 1)))) : 0))).ToString(), inCurrentBase); ;
            blNewEntry = true;
        }
        private void Factorial(object sender, EventArgs e)
        {
            if (inInfinityException != 1&&txtResult.Text.Contains(".")==false)
            {
                if (double.Parse(txtResult.Text) >= 0)
                    txtResult.Text = ConvertNumberSystem(10, (Fact(double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)))).ToString(), inCurrentBase);
                else
                {
                    txtResult.Text = "Invalid Input For Function";
                    inInfinityException = 1;
                }
                blNewEntry = true;
            }
        }
        double Fact(double dblOperand)
        {
            if (dblOperand == 0 || dblOperand == 1)
                return 1;
            else
                return dblOperand * Fact(dblOperand - 1);
        }
        private void Log(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                txtResult.Text = ((((Button)sender) == btnLogBase10) ? Math.Log10(double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10))) : Math.Log(double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)), Math.E)).ToString();
                if (inCurrentBase != 10) txtResult.Text = ConvertNumberSystem(10, txtResult.Text, inCurrentBase);
                blNewEntry = true;
            }
        }
        private void FindCube(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if(cbxSetInveseFunctions.Checked)
                    txtResult.Text = (dblResult = Math.Pow(double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)), (1.0/3))).ToString();
                else
                txtResult.Text = (dblResult = Math.Pow(double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)), 3)).ToString();
                if (inCurrentBase != 10)
                    txtResult.Text = ConvertNumberSystem(10, txtResult.Text, inCurrentBase);
                blNewEntry = true;
            }
        }
        private void FindSqure(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if(cbxSetInveseFunctions.Checked)
                    txtResult.Text = (dblResult = Math.Sqrt(double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)))).ToString();
                    else
                txtResult.Text = (dblResult = Math.Pow(double.Parse((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10)), 2)).ToString();
                if (inCurrentBase != 10)
                    txtResult.Text = ConvertNumberSystem(10, txtResult.Text, inCurrentBase);
               
            }
            blNewEntry = true;
        }
        private void AllowScientificNotation(object sender, EventArgs e)
        {
            if (inInfinityException != 1 && (double.Parse(txtResult.Text) != 0 & txtResult.Text.Contains('E') == false))
                txtResult.Text += "E+0";
        }
        private void SwitchOnAndOffScientificNotation(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if (txtResult.Text.Contains("E") == false)
                    txtResult.Text = double.Parse(txtResult.Text).ToString("E");
                else
                    txtResult.Text = (double.Parse(txtResult.Text, System.Globalization.NumberStyles.Float)).ToString();
            }
        }
        private void EnableButtonsOfStatitics(object sender, EventArgs e)
        {
            if (inInfinityException != 1 && btnStatiticsAverage.Enabled == false)
            {
                obj = new frmStatisticsForm(this);
                btnStatiticsAverage.Enabled = btnStatiticsSum.Enabled = btnStandardDeviation.Enabled = btnEnterStatiticsBoxEntry.Enabled = true;
                obj.Show();
            }
        }
        private void ForTrigonometricFunctions(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                dblResult = double.Parse(txtResult.Text);
                if (cbxSetInveseFunctions.Checked == false && cbxSetHyperbolicFunction.Checked == false)
                {
                    if (inConversionForTrigonometry == 1)
                        dblResult = dblResult * Math.PI / 180;
                    else if (inConversionForTrigonometry == 3)
                        dblResult = dblResult * Math.PI / 200;
                }
                if (((Button)sender) == btnSin)
                {
                    if (cbxSetHyperbolicFunction.Checked == false)
                        txtResult.Text = (dblResult = (cbxSetInveseFunctions.Checked) ? Math.Asin(dblResult) : Math.Sin(dblResult)).ToString();
                    else
                        txtResult.Text = (dblResult = (cbxSetInveseFunctions.Checked) ? (Math.Log((dblResult + Math.Sqrt(dblResult * dblResult + 1)), Math.E)) : Math.Sinh(dblResult)).ToString();
                }
                else if (((Button)sender) == btnCos)
                {
                    if (cbxSetHyperbolicFunction.Checked == false)
                        txtResult.Text = (dblResult = (cbxSetInveseFunctions.Checked) ? Math.Acos(dblResult) : Math.Cos(dblResult)).ToString();
                    else
                        txtResult.Text = (dblResult = (cbxSetInveseFunctions.Checked) ? (Math.Log(((1 + dblResult) / (1 - dblResult)), Math.E) / 2) : Math.Cosh(dblResult)).ToString();
                }
                else if (((Button)sender) == btnTan)
                {
                    if (cbxSetHyperbolicFunction.Checked == false)
                        txtResult.Text = (dblResult = (cbxSetInveseFunctions.Checked) ? Math.Atan(dblResult) : Math.Tan(dblResult)).ToString();
                    else
                        txtResult.Text = (dblResult = (cbxSetInveseFunctions.Checked) ? (Math.Log((dblResult + Math.Sqrt(dblResult * dblResult + 1)), Math.E)) : Math.Tanh(dblResult)).ToString();
                }
                if (cbxSetInveseFunctions.Checked && inConversionForTrigonometry != 2 && cbxSetHyperbolicFunction.Checked == false)
                {
                    if (inConversionForTrigonometry == 1)
                        dblResult = dblResult * 180 / Math.PI;
                    else if (inConversionForTrigonometry == 3)
                        dblResult = dblResult * 200 / Math.PI;
                    txtResult.Text = dblResult.ToString();
                }
                if (txtResult.Text == "NaN")                
                    txtResult.Text = "Invalid Input For Function";                
                blNewEntry = true;
            }
        }
        private void BalanceBrackets(object sender, EventArgs e)
        {
            if (inInfinityException != 1)
            {
                if (((Button)sender) == btnOpeningParenthesis)
                {
                    inParanthesisCount++;
                    txtResult.Text = new string('(', inParanthesisCount);
                }
                else if (((Button)sender) == btnClosingParenthesis && inParanthesisCount != 0)
                {
                    inParanthesisCount--;
                    dblOperand = Convert.ToDouble((inCurrentBase == 10) ? txtResult.Text : ConvertNumberSystem(inCurrentBase, txtResult.Text, 10));
                    Operate(dblResult, strPreviousOperator, dblOperand);
                }
                txtParanthesisIndicator.Text = "(=" + inParanthesisCount;
                if (inParanthesisCount == 0) txtParanthesisIndicator.Text = "";
                blNewEntry = true;
            }
        }
        private void AddCurrentResultBoxTextToStatistics(object sender, EventArgs e)
        {
            obj.lbxStatisticsEntries.Items.Add(txtResult.Text);
            blNewEntry = true;
            obj.lblStataticsEntryCount.Text = "n=" + obj.lbxStatisticsEntries.Items.Count;
        }
        private void StatiticsOperation(object sender, EventArgs e)
        {
            dblStatisticsResult = 0;
            if (sender as Button == btnStatiticsSum)
            {
                dblStatisticsResult = (cbxSetInveseFunctions.Checked) ? FindSum(2) : FindSum(1);
            }
            else if (sender as Button == btnStatiticsAverage)
            {
                int inCount = obj.lbxStatisticsEntries.Items.Count;
                dblStatisticsResult = (cbxSetInveseFunctions.Checked) ? FindSum(2)/inCount : FindSum(1) / inCount;
            }
            else
            {
                int inCount = obj.lbxStatisticsEntries.Items.Count;
                double dblAverage = FindSum(1) / inCount;
                foreach (var item in obj.lbxStatisticsEntries.Items)
                {
                    dblStatisticsResult += Math.Pow((double.Parse(item.ToString()) - dblAverage), 2);
                }
                dblStatisticsResult = Math.Sqrt(dblStatisticsResult / ((cbxSetInveseFunctions.Checked) ? inCount : inCount - 1));
            }
            txtResult.Text = dblStatisticsResult.ToString();
        }
        double FindSum(int inPower)
        {
            double dblNewResult = 0;
            foreach (var Entry in obj.lbxStatisticsEntries.Items)            
                dblNewResult += Math.Pow(double.Parse(Entry.ToString()), inPower);            
            return dblNewResult;
        }
        private void AllowedKeyboardEntries(object sender, KeyPressEventArgs e)
        {
            if (inInfinityException != 1)
            {
                switch ((int)e.KeyChar)
                {
                    case 8: btnBackspace.PerformClick(); break;
                    case 13: btnEquals.PerformClick(); break;
                    case 42: btnMultiply.PerformClick(); break;
                    case 43: btnAdd.PerformClick(); break;
                    case 45: btnSubstract.PerformClick(); break;
                    case 46: btnDecimalPoint.PerformClick(); break;
                    case 47: btnDivide.PerformClick(); break;
                    case 48: btnNumber0.PerformClick(); break;
                    case 49: btnNumber1.PerformClick(); break;
                    case 50: btnNumber2.PerformClick(); break;
                    case 51: btnNumber3.PerformClick(); break;
                    case 52: btnNumber4.PerformClick(); break;
                    case 53: btnNumber5.PerformClick(); break;
                    case 54: btnNumber6.PerformClick(); break;
                    case 55: btnNumber7.PerformClick(); break;
                    case 56: btnNumber8.PerformClick(); break;
                    case 57: btnNumber9.PerformClick(); break;
                    case 61: btnEquals.PerformClick(); break;
                }
            }
        }
        private void DegreeMinuteSecondFormatConversion(object sender, EventArgs e)
        {
            if (cbxSetInveseFunctions.Checked == false && inInfinityException != 1)
            {
                double d = double.Parse(txtResult.Text);
                double degree = (int)d;
                double minute = (int)((d - degree) * 60);
                double seconde = (int)((d - degree - (minute / 60)) * 3600);
                txtResult.Text = degree + "." + minute + "" + seconde;
            }
        }
    }
}
