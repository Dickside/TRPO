
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tRPOZakroitePojaluistaDataSet = new WindowsFormsApp1.TRPOZakroitePojaluistaDataSet();
            this.info_TouristsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.info_TouristsTableAdapter = new WindowsFormsApp1.TRPOZakroitePojaluistaDataSetTableAdapters.Info_TouristsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TRPOZakroitePojaluistaDataSetTableAdapters.TableAdapterManager();
            this.info_TouristsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.info_TouristsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.info_TouristsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turistiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turistiTableAdapter = new WindowsFormsApp1.TRPOZakroitePojaluistaDataSetTableAdapters.TuristiTableAdapter();
            this.turistiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tRPOZakroitePojaluistaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_TouristsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_TouristsBindingNavigator)).BeginInit();
            this.info_TouristsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_TouristsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tRPOZakroitePojaluistaDataSet
            // 
            this.tRPOZakroitePojaluistaDataSet.DataSetName = "TRPOZakroitePojaluistaDataSet";
            this.tRPOZakroitePojaluistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // info_TouristsBindingSource
            // 
            this.info_TouristsBindingSource.DataMember = "Info_Tourists";
            this.info_TouristsBindingSource.DataSource = this.tRPOZakroitePojaluistaDataSet;
            // 
            // info_TouristsTableAdapter
            // 
            this.info_TouristsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Info_TouristsTableAdapter = this.info_TouristsTableAdapter;
            this.tableAdapterManager.TuristiTableAdapter = this.turistiTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TRPOZakroitePojaluistaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // info_TouristsBindingNavigator
            // 
            this.info_TouristsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.info_TouristsBindingNavigator.BindingSource = this.info_TouristsBindingSource;
            this.info_TouristsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.info_TouristsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.info_TouristsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.info_TouristsBindingNavigatorSaveItem});
            this.info_TouristsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.info_TouristsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.info_TouristsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.info_TouristsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.info_TouristsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.info_TouristsBindingNavigator.Name = "info_TouristsBindingNavigator";
            this.info_TouristsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.info_TouristsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.info_TouristsBindingNavigator.TabIndex = 0;
            this.info_TouristsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // info_TouristsBindingNavigatorSaveItem
            // 
            this.info_TouristsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.info_TouristsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("info_TouristsBindingNavigatorSaveItem.Image")));
            this.info_TouristsBindingNavigatorSaveItem.Name = "info_TouristsBindingNavigatorSaveItem";
            this.info_TouristsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.info_TouristsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.info_TouristsBindingNavigatorSaveItem.Click += new System.EventHandler(this.info_TouristsBindingNavigatorSaveItem_Click);
            // 
            // info_TouristsDataGridView
            // 
            this.info_TouristsDataGridView.AutoGenerateColumns = false;
            this.info_TouristsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info_TouristsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.info_TouristsDataGridView.DataSource = this.info_TouristsBindingSource;
            this.info_TouristsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.info_TouristsDataGridView.Name = "info_TouristsDataGridView";
            this.info_TouristsDataGridView.Size = new System.Drawing.Size(645, 125);
            this.info_TouristsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Kod_Turista";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kod_Turista";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Seria_Passporta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Seria_Passporta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gorod";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Strana";
            this.dataGridViewTextBoxColumn4.HeaderText = "Strana";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "lndex";
            this.dataGridViewTextBoxColumn6.HeaderText = "lndex";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // turistiBindingSource
            // 
            this.turistiBindingSource.DataMember = "Turisti";
            this.turistiBindingSource.DataSource = this.tRPOZakroitePojaluistaDataSet;
            // 
            // turistiTableAdapter
            // 
            this.turistiTableAdapter.ClearBeforeFill = true;
            // 
            // turistiDataGridView
            // 
            this.turistiDataGridView.AutoGenerateColumns = false;
            this.turistiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turistiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.turistiDataGridView.DataSource = this.turistiBindingSource;
            this.turistiDataGridView.Location = new System.Drawing.Point(12, 234);
            this.turistiDataGridView.Name = "turistiDataGridView";
            this.turistiDataGridView.Size = new System.Drawing.Size(645, 220);
            this.turistiDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kod_Turista";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kod_Turista";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn10.HeaderText = "Patronymic";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.turistiDataGridView);
            this.Controls.Add(this.info_TouristsDataGridView);
            this.Controls.Add(this.info_TouristsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tRPOZakroitePojaluistaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_TouristsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_TouristsBindingNavigator)).EndInit();
            this.info_TouristsBindingNavigator.ResumeLayout(false);
            this.info_TouristsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_TouristsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TRPOZakroitePojaluistaDataSet tRPOZakroitePojaluistaDataSet;
        private System.Windows.Forms.BindingSource info_TouristsBindingSource;
        private TRPOZakroitePojaluistaDataSetTableAdapters.Info_TouristsTableAdapter info_TouristsTableAdapter;
        private TRPOZakroitePojaluistaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator info_TouristsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton info_TouristsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView info_TouristsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TRPOZakroitePojaluistaDataSetTableAdapters.TuristiTableAdapter turistiTableAdapter;
        private System.Windows.Forms.BindingSource turistiBindingSource;
        private System.Windows.Forms.DataGridView turistiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}

