﻿
namespace PlanTables
{
    partial class FormAddThing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.comboBoxUIuserName = new Sunny.UI.UIComboBox();
            this.textBoxAddThing = new Sunny.UI.UITextBox();
            this.textBox_addEmployee = new Sunny.UI.UITextBox();
            this.buttonAddThing = new Sunny.UI.UIButton();
            this.button_addEmployee = new Sunny.UI.UIButton();
            this.uiButton_notice = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // comboBoxUIuserName
            // 
            this.comboBoxUIuserName.DataSource = null;
            this.comboBoxUIuserName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboBoxUIuserName.FillColor = System.Drawing.Color.White;
            this.comboBoxUIuserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comboBoxUIuserName.Location = new System.Drawing.Point(11, 10);
            this.comboBoxUIuserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUIuserName.MinimumSize = new System.Drawing.Size(54, 0);
            this.comboBoxUIuserName.Name = "comboBoxUIuserName";
            this.comboBoxUIuserName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxUIuserName.Size = new System.Drawing.Size(129, 29);
            this.comboBoxUIuserName.TabIndex = 0;
            this.comboBoxUIuserName.TabStop = false;
            this.comboBoxUIuserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBoxUIuserName.Watermark = "选择下属";
            this.comboBoxUIuserName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // textBoxAddThing
            // 
            this.textBoxAddThing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddThing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxAddThing.Location = new System.Drawing.Point(147, 10);
            this.textBoxAddThing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddThing.MinimumSize = new System.Drawing.Size(1, 11);
            this.textBoxAddThing.Name = "textBoxAddThing";
            this.textBoxAddThing.ShowText = false;
            this.textBoxAddThing.Size = new System.Drawing.Size(265, 29);
            this.textBoxAddThing.TabIndex = 1;
            this.textBoxAddThing.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxAddThing.Watermark = "添加任务";
            this.textBoxAddThing.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxAddThing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddThing_KeyPress);
            // 
            // textBox_addEmployee
            // 
            this.textBox_addEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_addEmployee.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox_addEmployee.Location = new System.Drawing.Point(11, 47);
            this.textBox_addEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_addEmployee.MinimumSize = new System.Drawing.Size(1, 11);
            this.textBox_addEmployee.Name = "textBox_addEmployee";
            this.textBox_addEmployee.ShowText = false;
            this.textBox_addEmployee.Size = new System.Drawing.Size(129, 30);
            this.textBox_addEmployee.TabIndex = 2;
            this.textBox_addEmployee.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox_addEmployee.Watermark = "添加下属";
            this.textBox_addEmployee.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBox_addEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_addEmployee_KeyPress);
            // 
            // buttonAddThing
            // 
            this.buttonAddThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddThing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonAddThing.Location = new System.Drawing.Point(417, 10);
            this.buttonAddThing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddThing.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonAddThing.Name = "buttonAddThing";
            this.buttonAddThing.Size = new System.Drawing.Size(78, 29);
            this.buttonAddThing.TabIndex = 3;
            this.buttonAddThing.TabStop = false;
            this.buttonAddThing.Text = "添加任务";
            this.buttonAddThing.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddThing.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.buttonAddThing.Click += new System.EventHandler(this.buttonAddThing_Click);
            // 
            // button_addEmployee
            // 
            this.button_addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addEmployee.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button_addEmployee.Location = new System.Drawing.Point(146, 47);
            this.button_addEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_addEmployee.MinimumSize = new System.Drawing.Size(1, 1);
            this.button_addEmployee.Name = "button_addEmployee";
            this.button_addEmployee.Size = new System.Drawing.Size(81, 30);
            this.button_addEmployee.TabIndex = 4;
            this.button_addEmployee.TabStop = false;
            this.button_addEmployee.Text = "添加下属";
            this.button_addEmployee.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addEmployee.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.button_addEmployee.Click += new System.EventHandler(this.button_addEmployee_Click);
            // 
            // uiButton_notice
            // 
            this.uiButton_notice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_notice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiButton_notice.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiButton_notice.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.uiButton_notice.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiButton_notice.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiButton_notice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_notice.Location = new System.Drawing.Point(258, 47);
            this.uiButton_notice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton_notice.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_notice.Name = "uiButton_notice";
            this.uiButton_notice.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiButton_notice.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.uiButton_notice.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiButton_notice.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiButton_notice.Size = new System.Drawing.Size(237, 30);
            this.uiButton_notice.Style = Sunny.UI.UIStyle.Green;
            this.uiButton_notice.TabIndex = 5;
            this.uiButton_notice.TabStop = false;
            this.uiButton_notice.Text = "暂无添加您为下属的消息";
            this.uiButton_notice.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_notice.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton_notice.Click += new System.EventHandler(this.uiButton_notice_Click);
            // 
            // FormAddThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 83);
            this.Controls.Add(this.uiButton_notice);
            this.Controls.Add(this.button_addEmployee);
            this.Controls.Add(this.buttonAddThing);
            this.Controls.Add(this.textBox_addEmployee);
            this.Controls.Add(this.textBoxAddThing);
            this.Controls.Add(this.comboBoxUIuserName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddThing";
            this.Text = "增加任务";
            this.Load += new System.EventHandler(this.FormAddThing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox comboBoxUIuserName;
        private Sunny.UI.UITextBox textBoxAddThing;
        private Sunny.UI.UITextBox textBox_addEmployee;
        private Sunny.UI.UIButton buttonAddThing;
        private Sunny.UI.UIButton button_addEmployee;
        private Sunny.UI.UIButton uiButton_notice;
    }
}