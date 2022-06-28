namespace WindowsFormsApplication1
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        System.Windows.Forms.RadioButton[] ctrControlsForDecimalsSystem;
        System.Windows.Forms.RadioButton[] ctrControlsForNonDecimalsSystem;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlphabetF = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbtHexagonalNumberSystem = new System.Windows.Forms.RadioButton();
            this.gbNumberSystem = new System.Windows.Forms.GroupBox();
            this.rbtBinaryNumberSystem = new System.Windows.Forms.RadioButton();
            this.rbtOctalNumberSystem = new System.Windows.Forms.RadioButton();
            this.rbtDecimalNumberSystem = new System.Windows.Forms.RadioButton();
            this.gbConversions = new System.Windows.Forms.GroupBox();
            this.rbtDegree = new System.Windows.Forms.RadioButton();
            this.rbtRadians = new System.Windows.Forms.RadioButton();
            this.rbtGrads = new System.Windows.Forms.RadioButton();
            this.rbtDword = new System.Windows.Forms.RadioButton();
            this.rbtByte = new System.Windows.Forms.RadioButton();
            this.rbtQword = new System.Windows.Forms.RadioButton();
            this.rbtWord = new System.Windows.Forms.RadioButton();
            this.gpModeForTrigonometry = new System.Windows.Forms.GroupBox();
            this.cbxSetHyperbolicFunction = new System.Windows.Forms.CheckBox();
            this.cbxSetInveseFunctions = new System.Windows.Forms.CheckBox();
            this.btnAlphabetE = new System.Windows.Forms.Button();
            this.btnAlphabetD = new System.Windows.Forms.Button();
            this.btnAlphabetC = new System.Windows.Forms.Button();
            this.btnAlphabetB = new System.Windows.Forms.Button();
            this.btnAlphabetA = new System.Windows.Forms.Button();
            this.btnPiConstant = new System.Windows.Forms.Button();
            this.btnOneByNumber = new System.Windows.Forms.Button();
            this.btnXSquar = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnEnterStatiticsBoxEntry = new System.Windows.Forms.Button();
            this.btnIntegerPortionOnly = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnXCube = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnStandardDeviation = new System.Windows.Forms.Button();
            this.btnBitwiseInverse = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnMemorySet = new System.Windows.Forms.Button();
            this.btnLogBase10 = new System.Windows.Forms.Button();
            this.btnXRaiseToY = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnStatiticsSum = new System.Windows.Forms.Button();
            this.btnBitwiseXor = new System.Windows.Forms.Button();
            this.btnBitwiseOr = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnMemoryRead = new System.Windows.Forms.Button();
            this.btnLogBaseE = new System.Windows.Forms.Button();
            this.btnScientificNotation = new System.Windows.Forms.Button();
            this.btnDegreeMinuteSecondFormat = new System.Windows.Forms.Button();
            this.btnStatiticsAverage = new System.Windows.Forms.Button();
            this.btnBitwiseAnd = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnClosingParenthesis = new System.Windows.Forms.Button();
            this.btnOpeningParenthesis = new System.Windows.Forms.Button();
            this.btnOnAndOffScientificNotation = new System.Windows.Forms.Button();
            this.btnStatiticsBox = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.txtParanthesisIndicator = new System.Windows.Forms.TextBox();
            this.txtMemoryIndicator = new System.Windows.Forms.TextBox();
            this.gbNumberSystem.SuspendLayout();
            this.gbConversions.SuspendLayout();
            this.gpModeForTrigonometry.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlphabetF
            // 
            this.btnAlphabetF.Enabled = false;
            this.btnAlphabetF.ForeColor = System.Drawing.Color.Blue;
            this.btnAlphabetF.Location = new System.Drawing.Point(502, 257);
            this.btnAlphabetF.Name = "btnAlphabetF";
            this.btnAlphabetF.Size = new System.Drawing.Size(35, 28);
            this.btnAlphabetF.TabIndex = 0;
            this.btnAlphabetF.Text = "F";
            this.btnAlphabetF.UseVisualStyleBackColor = true;
            this.btnAlphabetF.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(525, 20);
            this.txtResult.TabIndex = 100;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtHexagonalNumberSystem
            // 
            this.rbtHexagonalNumberSystem.AutoSize = true;
            this.rbtHexagonalNumberSystem.Location = new System.Drawing.Point(6, 8);
            this.rbtHexagonalNumberSystem.Name = "rbtHexagonalNumberSystem";
            this.rbtHexagonalNumberSystem.Size = new System.Drawing.Size(44, 17);
            this.rbtHexagonalNumberSystem.TabIndex = 2;
            this.rbtHexagonalNumberSystem.Text = "Hex";
            this.rbtHexagonalNumberSystem.UseVisualStyleBackColor = true;
            this.rbtHexagonalNumberSystem.CheckedChanged += new System.EventHandler(this.DisplayProperConversionSystemAndDisables);
            // 
            // gbNumberSystem
            // 
            this.gbNumberSystem.Controls.Add(this.rbtBinaryNumberSystem);
            this.gbNumberSystem.Controls.Add(this.rbtOctalNumberSystem);
            this.gbNumberSystem.Controls.Add(this.rbtDecimalNumberSystem);
            this.gbNumberSystem.Controls.Add(this.rbtHexagonalNumberSystem);
            this.gbNumberSystem.Location = new System.Drawing.Point(12, 38);
            this.gbNumberSystem.Name = "gbNumberSystem";
            this.gbNumberSystem.Size = new System.Drawing.Size(252, 31);
            this.gbNumberSystem.TabIndex = 3;
            this.gbNumberSystem.TabStop = false;
            // 
            // rbtBinaryNumberSystem
            // 
            this.rbtBinaryNumberSystem.AutoSize = true;
            this.rbtBinaryNumberSystem.Location = new System.Drawing.Point(193, 8);
            this.rbtBinaryNumberSystem.Name = "rbtBinaryNumberSystem";
            this.rbtBinaryNumberSystem.Size = new System.Drawing.Size(40, 17);
            this.rbtBinaryNumberSystem.TabIndex = 2;
            this.rbtBinaryNumberSystem.Text = "Bin";
            this.rbtBinaryNumberSystem.UseVisualStyleBackColor = true;
            this.rbtBinaryNumberSystem.CheckedChanged += new System.EventHandler(this.DisplayProperConversionSystemAndDisables);
            // 
            // rbtOctalNumberSystem
            // 
            this.rbtOctalNumberSystem.AutoSize = true;
            this.rbtOctalNumberSystem.Location = new System.Drawing.Point(129, 7);
            this.rbtOctalNumberSystem.Name = "rbtOctalNumberSystem";
            this.rbtOctalNumberSystem.Size = new System.Drawing.Size(42, 17);
            this.rbtOctalNumberSystem.TabIndex = 2;
            this.rbtOctalNumberSystem.Text = "Oct";
            this.rbtOctalNumberSystem.UseVisualStyleBackColor = true;
            this.rbtOctalNumberSystem.CheckedChanged += new System.EventHandler(this.DisplayProperConversionSystemAndDisables);
            // 
            // rbtDecimalNumberSystem
            // 
            this.rbtDecimalNumberSystem.AutoSize = true;
            this.rbtDecimalNumberSystem.Checked = true;
            this.rbtDecimalNumberSystem.Location = new System.Drawing.Point(68, 8);
            this.rbtDecimalNumberSystem.Name = "rbtDecimalNumberSystem";
            this.rbtDecimalNumberSystem.Size = new System.Drawing.Size(45, 17);
            this.rbtDecimalNumberSystem.TabIndex = 2;
            this.rbtDecimalNumberSystem.TabStop = true;
            this.rbtDecimalNumberSystem.Text = "Dec";
            this.rbtDecimalNumberSystem.UseVisualStyleBackColor = true;
            this.rbtDecimalNumberSystem.CheckedChanged += new System.EventHandler(this.DisplayProperConversionSystemAndDisables);
            // 
            // gbConversions
            // 
            this.gbConversions.Controls.Add(this.rbtDegree);
            this.gbConversions.Controls.Add(this.rbtRadians);
            this.gbConversions.Controls.Add(this.rbtGrads);
            this.gbConversions.Location = new System.Drawing.Point(267, 38);
            this.gbConversions.Name = "gbConversions";
            this.gbConversions.Size = new System.Drawing.Size(270, 31);
            this.gbConversions.TabIndex = 0;
            this.gbConversions.TabStop = false;
            // 
            // rbtDegree
            // 
            this.rbtDegree.AutoSize = true;
            this.rbtDegree.Checked = true;
            this.rbtDegree.Location = new System.Drawing.Point(6, 8);
            this.rbtDegree.Name = "rbtDegree";
            this.rbtDegree.Size = new System.Drawing.Size(65, 17);
            this.rbtDegree.TabIndex = 2;
            this.rbtDegree.TabStop = true;
            this.rbtDegree.Text = "Degrees";
            this.rbtDegree.UseVisualStyleBackColor = true;
            this.rbtDegree.Click += new System.EventHandler(this.SetConversionStatusForTrigonometry);
            // 
            // rbtRadians
            // 
            this.rbtRadians.AutoSize = true;
            this.rbtRadians.Location = new System.Drawing.Point(102, 8);
            this.rbtRadians.Name = "rbtRadians";
            this.rbtRadians.Size = new System.Drawing.Size(64, 17);
            this.rbtRadians.TabIndex = 2;
            this.rbtRadians.Text = "Radians";
            this.rbtRadians.UseVisualStyleBackColor = true;
            this.rbtRadians.Click += new System.EventHandler(this.SetConversionStatusForTrigonometry);
            // 
            // rbtGrads
            // 
            this.rbtGrads.AutoSize = true;
            this.rbtGrads.Location = new System.Drawing.Point(210, 8);
            this.rbtGrads.Name = "rbtGrads";
            this.rbtGrads.Size = new System.Drawing.Size(53, 17);
            this.rbtGrads.TabIndex = 2;
            this.rbtGrads.Text = "Grads";
            this.rbtGrads.UseVisualStyleBackColor = true;
            this.rbtGrads.Click += new System.EventHandler(this.SetConversionStatusForTrigonometry);
            // 
            // rbtDword
            // 
            this.rbtDword.AutoSize = true;
            this.rbtDword.Location = new System.Drawing.Point(74, 9);
            this.rbtDword.Name = "rbtDword";
            this.rbtDword.Size = new System.Drawing.Size(56, 17);
            this.rbtDword.TabIndex = 2;
            this.rbtDword.Text = "Dword";
            this.rbtDword.UseVisualStyleBackColor = true;
            // 
            // rbtByte
            // 
            this.rbtByte.AutoSize = true;
            this.rbtByte.Location = new System.Drawing.Point(218, 9);
            this.rbtByte.Name = "rbtByte";
            this.rbtByte.Size = new System.Drawing.Size(46, 17);
            this.rbtByte.TabIndex = 2;
            this.rbtByte.Text = "Byte";
            this.rbtByte.UseVisualStyleBackColor = true;
            this.rbtByte.CheckedChanged += new System.EventHandler(this.ChangeConversionStatusForNonDecimal);
            // 
            // rbtQword
            // 
            this.rbtQword.AutoSize = true;
            this.rbtQword.Checked = true;
            this.rbtQword.Location = new System.Drawing.Point(6, 8);
            this.rbtQword.Name = "rbtQword";
            this.rbtQword.Size = new System.Drawing.Size(56, 17);
            this.rbtQword.TabIndex = 2;
            this.rbtQword.TabStop = true;
            this.rbtQword.Text = "Qword";
            this.rbtQword.UseVisualStyleBackColor = true;
            // 
            // rbtWord
            // 
            this.rbtWord.AutoSize = true;
            this.rbtWord.Location = new System.Drawing.Point(146, 9);
            this.rbtWord.Name = "rbtWord";
            this.rbtWord.Size = new System.Drawing.Size(51, 17);
            this.rbtWord.TabIndex = 2;
            this.rbtWord.Text = "Word";
            this.rbtWord.UseVisualStyleBackColor = true;
            // 
            // gpModeForTrigonometry
            // 
            this.gpModeForTrigonometry.Controls.Add(this.cbxSetHyperbolicFunction);
            this.gpModeForTrigonometry.Controls.Add(this.cbxSetInveseFunctions);
            this.gpModeForTrigonometry.Location = new System.Drawing.Point(12, 71);
            this.gpModeForTrigonometry.Name = "gpModeForTrigonometry";
            this.gpModeForTrigonometry.Size = new System.Drawing.Size(122, 35);
            this.gpModeForTrigonometry.TabIndex = 4;
            this.gpModeForTrigonometry.TabStop = false;
            // 
            // cbxSetHyperbolicFunction
            // 
            this.cbxSetHyperbolicFunction.AutoSize = true;
            this.cbxSetHyperbolicFunction.Location = new System.Drawing.Point(69, 12);
            this.cbxSetHyperbolicFunction.Name = "cbxSetHyperbolicFunction";
            this.cbxSetHyperbolicFunction.Size = new System.Drawing.Size(45, 17);
            this.cbxSetHyperbolicFunction.TabIndex = 0;
            this.cbxSetHyperbolicFunction.Text = "Hyp";
            this.cbxSetHyperbolicFunction.UseVisualStyleBackColor = true;
            // 
            // cbxSetInveseFunctions
            // 
            this.cbxSetInveseFunctions.AutoSize = true;
            this.cbxSetInveseFunctions.Location = new System.Drawing.Point(6, 12);
            this.cbxSetInveseFunctions.Name = "cbxSetInveseFunctions";
            this.cbxSetInveseFunctions.Size = new System.Drawing.Size(41, 17);
            this.cbxSetInveseFunctions.TabIndex = 0;
            this.cbxSetInveseFunctions.Text = "Inv";
            this.cbxSetInveseFunctions.UseVisualStyleBackColor = true;
            // 
            // btnAlphabetE
            // 
            this.btnAlphabetE.Enabled = false;
            this.btnAlphabetE.ForeColor = System.Drawing.Color.Blue;
            this.btnAlphabetE.Location = new System.Drawing.Point(461, 257);
            this.btnAlphabetE.Name = "btnAlphabetE";
            this.btnAlphabetE.Size = new System.Drawing.Size(35, 28);
            this.btnAlphabetE.TabIndex = 0;
            this.btnAlphabetE.Text = "E";
            this.btnAlphabetE.UseVisualStyleBackColor = true;
            this.btnAlphabetE.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetD
            // 
            this.btnAlphabetD.Enabled = false;
            this.btnAlphabetD.ForeColor = System.Drawing.Color.Blue;
            this.btnAlphabetD.Location = new System.Drawing.Point(420, 257);
            this.btnAlphabetD.Name = "btnAlphabetD";
            this.btnAlphabetD.Size = new System.Drawing.Size(35, 28);
            this.btnAlphabetD.TabIndex = 0;
            this.btnAlphabetD.Text = "D";
            this.btnAlphabetD.UseVisualStyleBackColor = true;
            this.btnAlphabetD.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetC
            // 
            this.btnAlphabetC.Enabled = false;
            this.btnAlphabetC.ForeColor = System.Drawing.Color.Blue;
            this.btnAlphabetC.Location = new System.Drawing.Point(379, 257);
            this.btnAlphabetC.Name = "btnAlphabetC";
            this.btnAlphabetC.Size = new System.Drawing.Size(35, 28);
            this.btnAlphabetC.TabIndex = 0;
            this.btnAlphabetC.Text = "C";
            this.btnAlphabetC.UseVisualStyleBackColor = true;
            this.btnAlphabetC.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetB
            // 
            this.btnAlphabetB.Enabled = false;
            this.btnAlphabetB.ForeColor = System.Drawing.Color.Blue;
            this.btnAlphabetB.Location = new System.Drawing.Point(338, 257);
            this.btnAlphabetB.Name = "btnAlphabetB";
            this.btnAlphabetB.Size = new System.Drawing.Size(35, 28);
            this.btnAlphabetB.TabIndex = 0;
            this.btnAlphabetB.Text = "B";
            this.btnAlphabetB.UseVisualStyleBackColor = true;
            this.btnAlphabetB.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnAlphabetA
            // 
            this.btnAlphabetA.Enabled = false;
            this.btnAlphabetA.ForeColor = System.Drawing.Color.Blue;
            this.btnAlphabetA.Location = new System.Drawing.Point(297, 257);
            this.btnAlphabetA.Name = "btnAlphabetA";
            this.btnAlphabetA.Size = new System.Drawing.Size(35, 28);
            this.btnAlphabetA.TabIndex = 0;
            this.btnAlphabetA.Text = "A";
            this.btnAlphabetA.UseVisualStyleBackColor = true;
            this.btnAlphabetA.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnPiConstant
            // 
            this.btnPiConstant.ForeColor = System.Drawing.Color.Blue;
            this.btnPiConstant.Location = new System.Drawing.Point(229, 257);
            this.btnPiConstant.Name = "btnPiConstant";
            this.btnPiConstant.Size = new System.Drawing.Size(35, 28);
            this.btnPiConstant.TabIndex = 0;
            this.btnPiConstant.Text = "pi";
            this.btnPiConstant.UseVisualStyleBackColor = true;
            this.btnPiConstant.Click += new System.EventHandler(this.SetPiValue);
            // 
            // btnOneByNumber
            // 
            this.btnOneByNumber.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnOneByNumber.Location = new System.Drawing.Point(162, 257);
            this.btnOneByNumber.Name = "btnOneByNumber";
            this.btnOneByNumber.Size = new System.Drawing.Size(35, 28);
            this.btnOneByNumber.TabIndex = 0;
            this.btnOneByNumber.Text = "1/x";
            this.btnOneByNumber.UseVisualStyleBackColor = true;
            this.btnOneByNumber.Click += new System.EventHandler(this.OneByNumber);
            // 
            // btnXSquar
            // 
            this.btnXSquar.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnXSquar.Location = new System.Drawing.Point(121, 257);
            this.btnXSquar.Name = "btnXSquar";
            this.btnXSquar.Size = new System.Drawing.Size(35, 28);
            this.btnXSquar.TabIndex = 0;
            this.btnXSquar.Text = "x^2";
            this.btnXSquar.UseVisualStyleBackColor = true;
            this.btnXSquar.Click += new System.EventHandler(this.FindSqure);
            // 
            // btnTan
            // 
            this.btnTan.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnTan.Location = new System.Drawing.Point(80, 257);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(35, 28);
            this.btnTan.TabIndex = 0;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnEnterStatiticsBoxEntry
            // 
            this.btnEnterStatiticsBoxEntry.Enabled = false;
            this.btnEnterStatiticsBoxEntry.ForeColor = System.Drawing.Color.Blue;
            this.btnEnterStatiticsBoxEntry.Location = new System.Drawing.Point(12, 257);
            this.btnEnterStatiticsBoxEntry.Name = "btnEnterStatiticsBoxEntry";
            this.btnEnterStatiticsBoxEntry.Size = new System.Drawing.Size(35, 28);
            this.btnEnterStatiticsBoxEntry.TabIndex = 0;
            this.btnEnterStatiticsBoxEntry.Text = "Dat";
            this.btnEnterStatiticsBoxEntry.UseVisualStyleBackColor = true;
            this.btnEnterStatiticsBoxEntry.Click += new System.EventHandler(this.AddCurrentResultBoxTextToStatistics);
            // 
            // btnIntegerPortionOnly
            // 
            this.btnIntegerPortionOnly.ForeColor = System.Drawing.Color.Red;
            this.btnIntegerPortionOnly.Location = new System.Drawing.Point(502, 223);
            this.btnIntegerPortionOnly.Name = "btnIntegerPortionOnly";
            this.btnIntegerPortionOnly.Size = new System.Drawing.Size(35, 28);
            this.btnIntegerPortionOnly.TabIndex = 0;
            this.btnIntegerPortionOnly.Text = "Int";
            this.btnIntegerPortionOnly.UseVisualStyleBackColor = true;
            this.btnIntegerPortionOnly.Click += new System.EventHandler(this.ShowIntegerOrfractionalPortion);
            // 
            // btnEquals
            // 
            this.btnEquals.ForeColor = System.Drawing.Color.Red;
            this.btnEquals.Location = new System.Drawing.Point(461, 223);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(35, 28);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.Equals);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(420, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimalPoint.ForeColor = System.Drawing.Color.Blue;
            this.btnDecimalPoint.Location = new System.Drawing.Point(379, 223);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(35, 28);
            this.btnDecimalPoint.TabIndex = 0;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = true;
            this.btnDecimalPoint.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.ForeColor = System.Drawing.Color.Blue;
            this.btnChangeSign.Location = new System.Drawing.Point(338, 223);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(35, 28);
            this.btnChangeSign.TabIndex = 0;
            this.btnChangeSign.Text = "+/-";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.ChangeSign);
            // 
            // btnNumber0
            // 
            this.btnNumber0.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber0.Location = new System.Drawing.Point(297, 223);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(35, 28);
            this.btnNumber0.TabIndex = 0;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            this.btnNumber0.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryAdd.Location = new System.Drawing.Point(229, 223);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(35, 28);
            this.btnMemoryAdd.TabIndex = 0;
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = true;
            this.btnMemoryAdd.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnFactorial.Location = new System.Drawing.Point(162, 223);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(35, 28);
            this.btnFactorial.TabIndex = 0;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.Factorial);
            // 
            // btnXCube
            // 
            this.btnXCube.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnXCube.Location = new System.Drawing.Point(121, 223);
            this.btnXCube.Name = "btnXCube";
            this.btnXCube.Size = new System.Drawing.Size(35, 28);
            this.btnXCube.TabIndex = 0;
            this.btnXCube.Text = "x^3";
            this.btnXCube.UseVisualStyleBackColor = true;
            this.btnXCube.Click += new System.EventHandler(this.FindCube);
            // 
            // btnCos
            // 
            this.btnCos.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnCos.Location = new System.Drawing.Point(80, 223);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(35, 28);
            this.btnCos.TabIndex = 0;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnStandardDeviation
            // 
            this.btnStandardDeviation.Enabled = false;
            this.btnStandardDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandardDeviation.ForeColor = System.Drawing.Color.Blue;
            this.btnStandardDeviation.Location = new System.Drawing.Point(12, 223);
            this.btnStandardDeviation.Name = "btnStandardDeviation";
            this.btnStandardDeviation.Size = new System.Drawing.Size(35, 28);
            this.btnStandardDeviation.TabIndex = 0;
            this.btnStandardDeviation.Text = "s";
            this.btnStandardDeviation.UseVisualStyleBackColor = true;
            this.btnStandardDeviation.Click += new System.EventHandler(this.StatiticsOperation);
            // 
            // btnBitwiseInverse
            // 
            this.btnBitwiseInverse.ForeColor = System.Drawing.Color.Red;
            this.btnBitwiseInverse.Location = new System.Drawing.Point(502, 189);
            this.btnBitwiseInverse.Name = "btnBitwiseInverse";
            this.btnBitwiseInverse.Size = new System.Drawing.Size(35, 28);
            this.btnBitwiseInverse.TabIndex = 0;
            this.btnBitwiseInverse.Text = "Not";
            this.btnBitwiseInverse.UseVisualStyleBackColor = true;
            this.btnBitwiseInverse.Click += new System.EventHandler(this.BitwiseInverse);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.ForeColor = System.Drawing.Color.Red;
            this.btnShiftLeft.Location = new System.Drawing.Point(461, 189);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(35, 28);
            this.btnShiftLeft.TabIndex = 0;
            this.btnShiftLeft.Text = "Lsh";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            this.btnShiftLeft.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.ForeColor = System.Drawing.Color.Red;
            this.btnSubstract.Location = new System.Drawing.Point(420, 189);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(35, 28);
            this.btnSubstract.TabIndex = 0;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnNumber3
            // 
            this.btnNumber3.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber3.Location = new System.Drawing.Point(379, 189);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(35, 28);
            this.btnNumber3.TabIndex = 0;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnNumber2
            // 
            this.btnNumber2.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber2.Location = new System.Drawing.Point(338, 189);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(35, 28);
            this.btnNumber2.TabIndex = 0;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnNumber1
            // 
            this.btnNumber1.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber1.Location = new System.Drawing.Point(297, 189);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(35, 28);
            this.btnNumber1.TabIndex = 0;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnMemorySet
            // 
            this.btnMemorySet.ForeColor = System.Drawing.Color.Red;
            this.btnMemorySet.Location = new System.Drawing.Point(229, 189);
            this.btnMemorySet.Name = "btnMemorySet";
            this.btnMemorySet.Size = new System.Drawing.Size(35, 28);
            this.btnMemorySet.TabIndex = 0;
            this.btnMemorySet.Text = "MS";
            this.btnMemorySet.UseVisualStyleBackColor = true;
            this.btnMemorySet.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // btnLogBase10
            // 
            this.btnLogBase10.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnLogBase10.Location = new System.Drawing.Point(162, 189);
            this.btnLogBase10.Name = "btnLogBase10";
            this.btnLogBase10.Size = new System.Drawing.Size(35, 28);
            this.btnLogBase10.TabIndex = 0;
            this.btnLogBase10.Text = "log";
            this.btnLogBase10.UseVisualStyleBackColor = true;
            this.btnLogBase10.Click += new System.EventHandler(this.Log);
            // 
            // btnXRaiseToY
            // 
            this.btnXRaiseToY.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnXRaiseToY.Location = new System.Drawing.Point(121, 189);
            this.btnXRaiseToY.Name = "btnXRaiseToY";
            this.btnXRaiseToY.Size = new System.Drawing.Size(35, 28);
            this.btnXRaiseToY.TabIndex = 0;
            this.btnXRaiseToY.Text = "x^y";
            this.btnXRaiseToY.UseVisualStyleBackColor = true;
            this.btnXRaiseToY.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnSin
            // 
            this.btnSin.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnSin.Location = new System.Drawing.Point(80, 189);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(35, 28);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.ForTrigonometricFunctions);
            // 
            // btnStatiticsSum
            // 
            this.btnStatiticsSum.Enabled = false;
            this.btnStatiticsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatiticsSum.ForeColor = System.Drawing.Color.Blue;
            this.btnStatiticsSum.Location = new System.Drawing.Point(12, 189);
            this.btnStatiticsSum.Name = "btnStatiticsSum";
            this.btnStatiticsSum.Size = new System.Drawing.Size(35, 28);
            this.btnStatiticsSum.TabIndex = 0;
            this.btnStatiticsSum.Text = "Sum";
            this.btnStatiticsSum.UseVisualStyleBackColor = true;
            this.btnStatiticsSum.Click += new System.EventHandler(this.StatiticsOperation);
            // 
            // btnBitwiseXor
            // 
            this.btnBitwiseXor.ForeColor = System.Drawing.Color.Red;
            this.btnBitwiseXor.Location = new System.Drawing.Point(502, 155);
            this.btnBitwiseXor.Name = "btnBitwiseXor";
            this.btnBitwiseXor.Size = new System.Drawing.Size(35, 28);
            this.btnBitwiseXor.TabIndex = 0;
            this.btnBitwiseXor.Text = "Xor";
            this.btnBitwiseXor.UseVisualStyleBackColor = true;
            this.btnBitwiseXor.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnBitwiseOr
            // 
            this.btnBitwiseOr.ForeColor = System.Drawing.Color.Red;
            this.btnBitwiseOr.Location = new System.Drawing.Point(461, 155);
            this.btnBitwiseOr.Name = "btnBitwiseOr";
            this.btnBitwiseOr.Size = new System.Drawing.Size(35, 28);
            this.btnBitwiseOr.TabIndex = 0;
            this.btnBitwiseOr.Text = "Or";
            this.btnBitwiseOr.UseVisualStyleBackColor = true;
            this.btnBitwiseOr.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnMultiply
            // 
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(420, 155);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(35, 28);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnNumber6
            // 
            this.btnNumber6.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber6.Location = new System.Drawing.Point(379, 155);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(35, 28);
            this.btnNumber6.TabIndex = 0;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnNumber5
            // 
            this.btnNumber5.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber5.Location = new System.Drawing.Point(338, 155);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(35, 28);
            this.btnNumber5.TabIndex = 0;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnNumber4
            // 
            this.btnNumber4.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber4.Location = new System.Drawing.Point(297, 155);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(35, 28);
            this.btnNumber4.TabIndex = 0;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnMemoryRead
            // 
            this.btnMemoryRead.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryRead.Location = new System.Drawing.Point(229, 155);
            this.btnMemoryRead.Name = "btnMemoryRead";
            this.btnMemoryRead.Size = new System.Drawing.Size(35, 28);
            this.btnMemoryRead.TabIndex = 0;
            this.btnMemoryRead.Text = "MR";
            this.btnMemoryRead.UseVisualStyleBackColor = true;
            this.btnMemoryRead.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // btnLogBaseE
            // 
            this.btnLogBaseE.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnLogBaseE.Location = new System.Drawing.Point(162, 155);
            this.btnLogBaseE.Name = "btnLogBaseE";
            this.btnLogBaseE.Size = new System.Drawing.Size(35, 28);
            this.btnLogBaseE.TabIndex = 0;
            this.btnLogBaseE.Text = "In";
            this.btnLogBaseE.UseVisualStyleBackColor = true;
            this.btnLogBaseE.Click += new System.EventHandler(this.Log);
            // 
            // btnScientificNotation
            // 
            this.btnScientificNotation.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnScientificNotation.Location = new System.Drawing.Point(121, 155);
            this.btnScientificNotation.Name = "btnScientificNotation";
            this.btnScientificNotation.Size = new System.Drawing.Size(35, 28);
            this.btnScientificNotation.TabIndex = 0;
            this.btnScientificNotation.Text = "Exp";
            this.btnScientificNotation.UseVisualStyleBackColor = true;
            this.btnScientificNotation.Click += new System.EventHandler(this.AllowScientificNotation);
            // 
            // btnDegreeMinuteSecondFormat
            // 
            this.btnDegreeMinuteSecondFormat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnDegreeMinuteSecondFormat.Location = new System.Drawing.Point(80, 155);
            this.btnDegreeMinuteSecondFormat.Name = "btnDegreeMinuteSecondFormat";
            this.btnDegreeMinuteSecondFormat.Size = new System.Drawing.Size(35, 28);
            this.btnDegreeMinuteSecondFormat.TabIndex = 0;
            this.btnDegreeMinuteSecondFormat.Text = "dms";
            this.btnDegreeMinuteSecondFormat.UseVisualStyleBackColor = true;
            this.btnDegreeMinuteSecondFormat.Click += new System.EventHandler(this.DegreeMinuteSecondFormatConversion);
            // 
            // btnStatiticsAverage
            // 
            this.btnStatiticsAverage.Enabled = false;
            this.btnStatiticsAverage.ForeColor = System.Drawing.Color.Blue;
            this.btnStatiticsAverage.Location = new System.Drawing.Point(12, 155);
            this.btnStatiticsAverage.Name = "btnStatiticsAverage";
            this.btnStatiticsAverage.Size = new System.Drawing.Size(35, 28);
            this.btnStatiticsAverage.TabIndex = 0;
            this.btnStatiticsAverage.Text = "Ave";
            this.btnStatiticsAverage.UseVisualStyleBackColor = true;
            this.btnStatiticsAverage.Click += new System.EventHandler(this.StatiticsOperation);
            // 
            // btnBitwiseAnd
            // 
            this.btnBitwiseAnd.ForeColor = System.Drawing.Color.Red;
            this.btnBitwiseAnd.Location = new System.Drawing.Point(502, 121);
            this.btnBitwiseAnd.Name = "btnBitwiseAnd";
            this.btnBitwiseAnd.Size = new System.Drawing.Size(35, 28);
            this.btnBitwiseAnd.TabIndex = 0;
            this.btnBitwiseAnd.Text = "And";
            this.btnBitwiseAnd.UseVisualStyleBackColor = true;
            this.btnBitwiseAnd.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnModulus
            // 
            this.btnModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulus.ForeColor = System.Drawing.Color.Red;
            this.btnModulus.Location = new System.Drawing.Point(461, 121);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(35, 28);
            this.btnModulus.TabIndex = 0;
            this.btnModulus.Text = "Mod";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnDivide
            // 
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(420, 121);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(35, 28);
            this.btnDivide.TabIndex = 0;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperatorFound);
            // 
            // btnNumber9
            // 
            this.btnNumber9.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber9.Location = new System.Drawing.Point(379, 121);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(35, 28);
            this.btnNumber9.TabIndex = 0;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnNumber8
            // 
            this.btnNumber8.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber8.Location = new System.Drawing.Point(338, 121);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(35, 28);
            this.btnNumber8.TabIndex = 0;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnNumber7
            // 
            this.btnNumber7.ForeColor = System.Drawing.Color.Blue;
            this.btnNumber7.Location = new System.Drawing.Point(297, 121);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(35, 28);
            this.btnNumber7.TabIndex = 0;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.UpdateOperand);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryClear.Location = new System.Drawing.Point(229, 121);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(35, 28);
            this.btnMemoryClear.TabIndex = 0;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.MemmoryOperations);
            // 
            // btnClosingParenthesis
            // 
            this.btnClosingParenthesis.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnClosingParenthesis.Location = new System.Drawing.Point(162, 121);
            this.btnClosingParenthesis.Name = "btnClosingParenthesis";
            this.btnClosingParenthesis.Size = new System.Drawing.Size(35, 28);
            this.btnClosingParenthesis.TabIndex = 0;
            this.btnClosingParenthesis.Text = ")";
            this.btnClosingParenthesis.UseVisualStyleBackColor = true;
            this.btnClosingParenthesis.Click += new System.EventHandler(this.BalanceBrackets);
            // 
            // btnOpeningParenthesis
            // 
            this.btnOpeningParenthesis.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnOpeningParenthesis.Location = new System.Drawing.Point(121, 121);
            this.btnOpeningParenthesis.Name = "btnOpeningParenthesis";
            this.btnOpeningParenthesis.Size = new System.Drawing.Size(35, 28);
            this.btnOpeningParenthesis.TabIndex = 0;
            this.btnOpeningParenthesis.Text = "(";
            this.btnOpeningParenthesis.UseVisualStyleBackColor = true;
            this.btnOpeningParenthesis.Click += new System.EventHandler(this.BalanceBrackets);
            // 
            // btnOnAndOffScientificNotation
            // 
            this.btnOnAndOffScientificNotation.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnOnAndOffScientificNotation.Location = new System.Drawing.Point(80, 121);
            this.btnOnAndOffScientificNotation.Name = "btnOnAndOffScientificNotation";
            this.btnOnAndOffScientificNotation.Size = new System.Drawing.Size(35, 28);
            this.btnOnAndOffScientificNotation.TabIndex = 0;
            this.btnOnAndOffScientificNotation.Text = "F-E";
            this.btnOnAndOffScientificNotation.UseVisualStyleBackColor = true;
            this.btnOnAndOffScientificNotation.Click += new System.EventHandler(this.SwitchOnAndOffScientificNotation);
            // 
            // btnStatiticsBox
            // 
            this.btnStatiticsBox.ForeColor = System.Drawing.Color.Blue;
            this.btnStatiticsBox.Location = new System.Drawing.Point(12, 121);
            this.btnStatiticsBox.Name = "btnStatiticsBox";
            this.btnStatiticsBox.Size = new System.Drawing.Size(35, 28);
            this.btnStatiticsBox.TabIndex = 0;
            this.btnStatiticsBox.Text = "Sta";
            this.btnStatiticsBox.UseVisualStyleBackColor = true;
            this.btnStatiticsBox.Click += new System.EventHandler(this.EnableButtonsOfStatitics);
            // 
            // btnBackspace
            // 
            this.btnBackspace.ForeColor = System.Drawing.Color.Red;
            this.btnBackspace.Location = new System.Drawing.Point(297, 78);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(76, 28);
            this.btnBackspace.TabIndex = 0;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.RemoveLastDigit);
            // 
            // btnCE
            // 
            this.btnCE.ForeColor = System.Drawing.Color.Red;
            this.btnCE.Location = new System.Drawing.Point(379, 78);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(76, 28);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.ClearOperator);
            // 
            // btnC
            // 
            this.btnC.ForeColor = System.Drawing.Color.Red;
            this.btnC.Location = new System.Drawing.Point(461, 78);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(76, 28);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.ClearExceptMemory);
            // 
            // txtParanthesisIndicator
            // 
            this.txtParanthesisIndicator.Location = new System.Drawing.Point(167, 83);
            this.txtParanthesisIndicator.Name = "txtParanthesisIndicator";
            this.txtParanthesisIndicator.ReadOnly = true;
            this.txtParanthesisIndicator.Size = new System.Drawing.Size(28, 20);
            this.txtParanthesisIndicator.TabIndex = 5;
            // 
            // txtMemoryIndicator
            // 
            this.txtMemoryIndicator.Location = new System.Drawing.Point(233, 83);
            this.txtMemoryIndicator.Name = "txtMemoryIndicator";
            this.txtMemoryIndicator.ReadOnly = true;
            this.txtMemoryIndicator.Size = new System.Drawing.Size(28, 20);
            this.txtMemoryIndicator.TabIndex = 5;
            this.txtMemoryIndicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 301);
            this.Controls.Add(this.txtMemoryIndicator);
            this.Controls.Add(this.txtParanthesisIndicator);
            this.Controls.Add(this.gpModeForTrigonometry);
            this.Controls.Add(this.gbConversions);
            this.Controls.Add(this.gbNumberSystem);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnStatiticsBox);
            this.Controls.Add(this.btnOnAndOffScientificNotation);
            this.Controls.Add(this.btnStatiticsAverage);
            this.Controls.Add(this.btnDegreeMinuteSecondFormat);
            this.Controls.Add(this.btnStatiticsSum);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnOpeningParenthesis);
            this.Controls.Add(this.btnStandardDeviation);
            this.Controls.Add(this.btnScientificNotation);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnXRaiseToY);
            this.Controls.Add(this.btnClosingParenthesis);
            this.Controls.Add(this.btnEnterStatiticsBoxEntry);
            this.Controls.Add(this.btnLogBaseE);
            this.Controls.Add(this.btnXCube);
            this.Controls.Add(this.btnLogBase10);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnMemoryRead);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnMemorySet);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnNumber7);
            this.Controls.Add(this.btnXSquar);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnMemoryAdd);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.btnNumber8);
            this.Controls.Add(this.btnOneByNumber);
            this.Controls.Add(this.btnNumber5);
            this.Controls.Add(this.btnNumber0);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber9);
            this.Controls.Add(this.btnPiConstant);
            this.Controls.Add(this.btnNumber6);
            this.Controls.Add(this.btnChangeSign);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAlphabetA);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDecimalPoint);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnAlphabetB);
            this.Controls.Add(this.btnBitwiseOr);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShiftLeft);
            this.Controls.Add(this.btnBitwiseAnd);
            this.Controls.Add(this.btnAlphabetC);
            this.Controls.Add(this.btnBitwiseXor);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnBitwiseInverse);
            this.Controls.Add(this.btnAlphabetD);
            this.Controls.Add(this.btnIntegerPortionOnly);
            this.Controls.Add(this.btnAlphabetE);
            this.Controls.Add(this.btnAlphabetF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmMainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scientific Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowedKeyboardEntries);
            this.gbNumberSystem.ResumeLayout(false);
            this.gbNumberSystem.PerformLayout();
            this.gbConversions.ResumeLayout(false);
            this.gbConversions.PerformLayout();
            this.gpModeForTrigonometry.ResumeLayout(false);
            this.gpModeForTrigonometry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void AdditionalInitialisation()
        {
            ctrControlsForDecimalsSystem = new System.Windows.Forms.RadioButton[] { rbtDegree, rbtRadians, rbtGrads };
            ctrControlsForNonDecimalsSystem=new System.Windows.Forms.RadioButton[] {rbtDword,rbtQword,rbtWord,rbtByte};
        }

        #endregion

        private System.Windows.Forms.Button btnAlphabetF;
        public System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbtHexagonalNumberSystem;
        private System.Windows.Forms.GroupBox gbNumberSystem;
        private System.Windows.Forms.RadioButton rbtBinaryNumberSystem;
        private System.Windows.Forms.RadioButton rbtOctalNumberSystem;
        private System.Windows.Forms.RadioButton rbtDecimalNumberSystem;
        private System.Windows.Forms.GroupBox gbConversions;
        private System.Windows.Forms.RadioButton rbtGrads;
        private System.Windows.Forms.RadioButton rbtRadians;
        private System.Windows.Forms.RadioButton rbtDegree;
        private System.Windows.Forms.GroupBox gpModeForTrigonometry;
        private System.Windows.Forms.CheckBox cbxSetHyperbolicFunction;
        private System.Windows.Forms.CheckBox cbxSetInveseFunctions;
        private System.Windows.Forms.Button btnAlphabetE;
        private System.Windows.Forms.Button btnAlphabetD;
        private System.Windows.Forms.Button btnAlphabetC;
        private System.Windows.Forms.Button btnAlphabetB;
        private System.Windows.Forms.Button btnAlphabetA;
        private System.Windows.Forms.Button btnPiConstant;
        private System.Windows.Forms.Button btnOneByNumber;
        private System.Windows.Forms.Button btnXSquar;
        private System.Windows.Forms.Button btnTan;
        public System.Windows.Forms.Button btnEnterStatiticsBoxEntry;
        private System.Windows.Forms.Button btnIntegerPortionOnly;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnXCube;
        private System.Windows.Forms.Button btnCos;
        public System.Windows.Forms.Button btnStandardDeviation;
        private System.Windows.Forms.Button btnBitwiseInverse;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnMemorySet;
        private System.Windows.Forms.Button btnLogBase10;
        private System.Windows.Forms.Button btnXRaiseToY;
        private System.Windows.Forms.Button btnSin;
        public System.Windows.Forms.Button btnStatiticsSum;
        private System.Windows.Forms.Button btnBitwiseXor;
        private System.Windows.Forms.Button btnBitwiseOr;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnMemoryRead;
        private System.Windows.Forms.Button btnLogBaseE;
        private System.Windows.Forms.Button btnScientificNotation;
        private System.Windows.Forms.Button btnDegreeMinuteSecondFormat;
        public System.Windows.Forms.Button btnStatiticsAverage;
        private System.Windows.Forms.Button btnBitwiseAnd;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnClosingParenthesis;
        private System.Windows.Forms.Button btnOpeningParenthesis;
        private System.Windows.Forms.Button btnOnAndOffScientificNotation;
        private System.Windows.Forms.Button btnStatiticsBox;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox txtParanthesisIndicator;
        private System.Windows.Forms.TextBox txtMemoryIndicator;
        private System.Windows.Forms.RadioButton rbtQword;
        private System.Windows.Forms.RadioButton rbtDword;
        private System.Windows.Forms.RadioButton rbtWord;
        private System.Windows.Forms.RadioButton rbtByte;
    }
}

