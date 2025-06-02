using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Preview;

namespace VitaPharm.Reports
{
    partial class frmRevenueReportViewer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevenueReportViewer));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            dateEditTo = new DevExpress.XtraEditors.DateEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnViewReport = new DevExpress.XtraEditors.SimpleButton();
            documentViewer = new DocumentViewer();
            documentViewerBarManager1 = new DocumentViewerBarManager(components);
            barDockControlTop = new BarDockControl();
            barDockControlBottom = new BarDockControl();
            barDockControlLeft = new BarDockControl();
            barDockControlRight = new BarDockControl();
            previewBar1 = new PreviewBar();
            previewBar2 = new PreviewBar();
            printPreviewStaticItemPageOfPages = new PrintPreviewStaticItem();
            repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            progressBarEditItem = new ProgressBarEditItem();
            printPreviewBarItem1 = new PrintPreviewBarItem();
            printPreviewStaticItemZoomFactor = new PrintPreviewStaticItem();
            repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            zoomTrackBarEditItem = new ZoomTrackBarEditItem();
            bbiDocumentMap = new PrintPreviewBarItem();
            bbiParameters = new PrintPreviewBarItem();
            bbiThumbnails = new PrintPreviewBarItem();
            bbiFind = new PrintPreviewBarItem();
            bbiHighlightEditingFields = new PrintPreviewBarItem();
            bbiCustomize = new PrintPreviewBarItem();
            bbiOpen = new PrintPreviewBarItem();
            bbiSave = new PrintPreviewBarItem();
            bbiPrint = new PrintPreviewBarItem();
            bbiPrintDirect = new PrintPreviewBarItem();
            bbiPageSetup = new PrintPreviewBarItem();
            bbiEditPageHF = new PrintPreviewBarItem();
            bbiScale = new PrintPreviewBarItem();
            bbiHandTool = new PrintPreviewBarItem();
            bbiMagnifier = new PrintPreviewBarItem();
            bbiZoomOut = new PrintPreviewBarItem();
            bbiZoom = new ZoomBarEditItem();
            printPreviewRepositoryItemComboBox1 = new PrintPreviewRepositoryItemComboBox();
            bbiZoomIn = new PrintPreviewBarItem();
            bbiShowFirstPage = new PrintPreviewBarItem();
            bbiShowPrevPage = new PrintPreviewBarItem();
            bbiShowNextPage = new PrintPreviewBarItem();
            bbiShowLastPage = new PrintPreviewBarItem();
            bbiMultiplePages = new PrintPreviewBarItem();
            bbiFillBackground = new PrintPreviewBarItem();
            bbiWatermark = new PrintPreviewBarItem();
            bbiExportFile = new PrintPreviewBarItem();
            bbiSendFile = new PrintPreviewBarItem();
            bbiClosePreview = new PrintPreviewBarItem();
            miFile = new PrintPreviewSubItem();
            miView = new PrintPreviewSubItem();
            miBackground = new PrintPreviewSubItem();
            miPageLayout = new PrintPreviewSubItem();
            miPageLayoutFacing = new PrintPreviewBarItem();
            miPageLayoutContinuous = new PrintPreviewBarItem();
            miToolbars = new BarToolbarsListItem();
            printPreviewBarCheckItem1 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem2 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem3 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem4 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem5 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem6 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem7 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem8 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem9 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem10 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem11 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem12 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem13 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem14 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem15 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem16 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem17 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem18 = new PrintPreviewBarCheckItem();
            printPreviewBarCheckItem19 = new PrintPreviewBarCheckItem();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentViewerBarManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemProgressBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemZoomTrackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)printPreviewRepositoryItemComboBox1).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(33, 20);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(38, 18);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "From";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(295, 20);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(18, 18);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "To";
            // 
            // dateEditFrom
            // 
            dateEditFrom.EditValue = null;
            dateEditFrom.Location = new Point(92, 18);
            dateEditFrom.Name = "dateEditFrom";
            dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditFrom.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateEditFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditFrom.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateEditFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditFrom.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            dateEditFrom.Properties.UseMaskAsDisplayFormat = true;
            dateEditFrom.Size = new Size(145, 22);
            dateEditFrom.TabIndex = 23;
            // 
            // dateEditTo
            // 
            dateEditTo.EditValue = null;
            dateEditTo.Location = new Point(343, 18);
            dateEditTo.Name = "dateEditTo";
            dateEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateEditTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditTo.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateEditTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditTo.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            dateEditTo.Properties.UseMaskAsDisplayFormat = true;
            dateEditTo.Size = new Size(145, 22);
            dateEditTo.TabIndex = 24;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.White;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.Controls.Add(btnViewReport);
            panelControl1.Controls.Add(dateEditTo);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(dateEditFrom);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(698, 62);
            panelControl1.TabIndex = 25;
            // 
            // btnViewReport
            // 
            btnViewReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewReport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            btnViewReport.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReport.Appearance.Options.UseBackColor = true;
            btnViewReport.Appearance.Options.UseFont = true;
            btnViewReport.Location = new Point(547, 12);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(119, 34);
            btnViewReport.TabIndex = 25;
            btnViewReport.Text = "View Report";
            btnViewReport.Click += btnViewReport_Click;
            // 
            // documentViewer
            // 
            documentViewer.Dock = DockStyle.Fill;
            documentViewer.IsMetric = false;
            documentViewer.Location = new Point(0, 62);
            documentViewer.Margin = new Padding(4, 4, 4, 4);
            documentViewer.Name = "documentViewer";
            documentViewer.Size = new Size(698, 240);
            documentViewer.TabIndex = 26;
            // 
            // documentViewerBarManager1
            // 
            documentViewerBarManager1.Bars.AddRange(new Bar[] { previewBar1, previewBar2 });
            documentViewerBarManager1.DockControls.Add(barDockControlTop);
            documentViewerBarManager1.DockControls.Add(barDockControlBottom);
            documentViewerBarManager1.DockControls.Add(barDockControlLeft);
            documentViewerBarManager1.DockControls.Add(barDockControlRight);
            documentViewerBarManager1.DocumentViewer = documentViewer;
            documentViewerBarManager1.Form = this;
            documentViewerBarManager1.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("documentViewerBarManager1.ImageStream");
            documentViewerBarManager1.Items.AddRange(new BarItem[] { printPreviewStaticItemPageOfPages, progressBarEditItem, printPreviewBarItem1, printPreviewStaticItemZoomFactor, zoomTrackBarEditItem, bbiDocumentMap, bbiParameters, bbiThumbnails, bbiFind, bbiHighlightEditingFields, bbiCustomize, bbiOpen, bbiSave, bbiPrint, bbiPrintDirect, bbiPageSetup, bbiEditPageHF, bbiScale, bbiHandTool, bbiMagnifier, bbiZoomOut, bbiZoom, bbiZoomIn, bbiShowFirstPage, bbiShowPrevPage, bbiShowNextPage, bbiShowLastPage, bbiMultiplePages, bbiFillBackground, bbiWatermark, bbiExportFile, bbiSendFile, bbiClosePreview, miFile, miView, miBackground, miPageLayout, miPageLayoutFacing, miPageLayoutContinuous, miToolbars, printPreviewBarCheckItem1, printPreviewBarCheckItem2, printPreviewBarCheckItem3, printPreviewBarCheckItem4, printPreviewBarCheckItem5, printPreviewBarCheckItem6, printPreviewBarCheckItem7, printPreviewBarCheckItem8, printPreviewBarCheckItem9, printPreviewBarCheckItem10, printPreviewBarCheckItem11, printPreviewBarCheckItem12, printPreviewBarCheckItem13, printPreviewBarCheckItem14, printPreviewBarCheckItem15, printPreviewBarCheckItem16, printPreviewBarCheckItem17, printPreviewBarCheckItem18, printPreviewBarCheckItem19 });
            documentViewerBarManager1.MaxItemId = 59;
            documentViewerBarManager1.PreviewBar = previewBar1;
            documentViewerBarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemProgressBar1, repositoryItemZoomTrackBar1, printPreviewRepositoryItemComboBox1 });
            documentViewerBarManager1.StatusBar = previewBar2;
            documentViewerBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = documentViewerBarManager1;
            barDockControlTop.Size = new Size(698, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 302);
            barDockControlBottom.Manager = documentViewerBarManager1;
            barDockControlBottom.Size = new Size(698, 58);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = documentViewerBarManager1;
            barDockControlLeft.Size = new Size(0, 302);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(698, 0);
            barDockControlRight.Manager = documentViewerBarManager1;
            barDockControlRight.Size = new Size(0, 302);
            // 
            // previewBar1
            // 
            previewBar1.BarName = "Toolbar";
            previewBar1.DockCol = 0;
            previewBar1.DockRow = 1;
            previewBar1.DockStyle = BarDockStyle.Bottom;
            previewBar1.FloatLocation = new Point(443, 581);
            previewBar1.FloatSize = new Size(546, 96);
            previewBar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(bbiDocumentMap), new LinkPersistInfo(bbiParameters), new LinkPersistInfo(bbiThumbnails), new LinkPersistInfo(bbiFind), new LinkPersistInfo(bbiHighlightEditingFields), new LinkPersistInfo(bbiCustomize, true), new LinkPersistInfo(bbiOpen, true), new LinkPersistInfo(bbiSave), new LinkPersistInfo(bbiPrint, true), new LinkPersistInfo(bbiPrintDirect), new LinkPersistInfo(bbiPageSetup), new LinkPersistInfo(bbiEditPageHF), new LinkPersistInfo(bbiScale), new LinkPersistInfo(bbiHandTool, true), new LinkPersistInfo(bbiMagnifier), new LinkPersistInfo(bbiZoomOut, true), new LinkPersistInfo(bbiZoom), new LinkPersistInfo(bbiZoomIn), new LinkPersistInfo(bbiShowFirstPage, true), new LinkPersistInfo(bbiShowPrevPage), new LinkPersistInfo(bbiShowNextPage), new LinkPersistInfo(bbiShowLastPage), new LinkPersistInfo(bbiMultiplePages, true), new LinkPersistInfo(bbiFillBackground), new LinkPersistInfo(bbiWatermark), new LinkPersistInfo(bbiExportFile, true), new LinkPersistInfo(bbiSendFile), new LinkPersistInfo(bbiClosePreview, true) });
            previewBar1.Offset = 16;
            previewBar1.Text = "Toolbar";
            // 
            // previewBar2
            // 
            previewBar2.BarName = "Status Bar";
            previewBar2.CanDockStyle = BarCanDockStyle.Bottom;
            previewBar2.DockCol = 0;
            previewBar2.DockRow = 0;
            previewBar2.DockStyle = BarDockStyle.Bottom;
            previewBar2.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(printPreviewStaticItemPageOfPages), new LinkPersistInfo(progressBarEditItem), new LinkPersistInfo(printPreviewBarItem1), new LinkPersistInfo(printPreviewStaticItemZoomFactor, true), new LinkPersistInfo(zoomTrackBarEditItem) });
            previewBar2.OptionsBar.AllowQuickCustomization = false;
            previewBar2.OptionsBar.DrawDragBorder = false;
            previewBar2.OptionsBar.UseWholeRow = true;
            previewBar2.Text = "Status Bar";
            // 
            // printPreviewStaticItemPageOfPages
            // 
            printPreviewStaticItemPageOfPages.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            printPreviewStaticItemPageOfPages.Caption = "Nothing";
            printPreviewStaticItemPageOfPages.Id = 0;
            printPreviewStaticItemPageOfPages.LeftIndent = 1;
            printPreviewStaticItemPageOfPages.Name = "printPreviewStaticItemPageOfPages";
            printPreviewStaticItemPageOfPages.RightIndent = 1;
            printPreviewStaticItemPageOfPages.Type = "PageOfPages";
            // 
            // repositoryItemProgressBar1
            // 
            repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // progressBarEditItem
            // 
            progressBarEditItem.Edit = repositoryItemProgressBar1;
            progressBarEditItem.EditHeight = 12;
            progressBarEditItem.EditWidth = 150;
            progressBarEditItem.Id = 1;
            progressBarEditItem.Name = "progressBarEditItem";
            progressBarEditItem.Visibility = BarItemVisibility.Never;
            // 
            // printPreviewBarItem1
            // 
            printPreviewBarItem1.Caption = "Stop";
            printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding;
            printPreviewBarItem1.Enabled = false;
            printPreviewBarItem1.Hint = "Stop";
            printPreviewBarItem1.Id = 2;
            printPreviewBarItem1.Name = "printPreviewBarItem1";
            printPreviewBarItem1.Visibility = BarItemVisibility.Never;
            // 
            // printPreviewStaticItemZoomFactor
            // 
            printPreviewStaticItemZoomFactor.Alignment = BarItemLinkAlignment.Right;
            printPreviewStaticItemZoomFactor.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            printPreviewStaticItemZoomFactor.Caption = "100%";
            printPreviewStaticItemZoomFactor.Id = 3;
            printPreviewStaticItemZoomFactor.Name = "printPreviewStaticItemZoomFactor";
            printPreviewStaticItemZoomFactor.TextAlignment = StringAlignment.Far;
            printPreviewStaticItemZoomFactor.Type = "ZoomFactor";
            // 
            // repositoryItemZoomTrackBar1
            // 
            repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            repositoryItemZoomTrackBar1.AllowFocused = false;
            repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            repositoryItemZoomTrackBar1.Maximum = 180;
            repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            // 
            // zoomTrackBarEditItem
            // 
            zoomTrackBarEditItem.Alignment = BarItemLinkAlignment.Right;
            zoomTrackBarEditItem.Edit = repositoryItemZoomTrackBar1;
            zoomTrackBarEditItem.EditValue = 90;
            zoomTrackBarEditItem.EditWidth = 140;
            zoomTrackBarEditItem.Enabled = false;
            zoomTrackBarEditItem.Id = 4;
            zoomTrackBarEditItem.Name = "zoomTrackBarEditItem";
            zoomTrackBarEditItem.Range = new int[]
    {
    10,
    500
    };
            // 
            // bbiDocumentMap
            // 
            bbiDocumentMap.ButtonStyle = BarButtonStyle.Check;
            bbiDocumentMap.Caption = "Document Map";
            bbiDocumentMap.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap;
            bbiDocumentMap.Enabled = false;
            bbiDocumentMap.Hint = "Document Map";
            bbiDocumentMap.Id = 5;
            bbiDocumentMap.Name = "bbiDocumentMap";
            // 
            // bbiParameters
            // 
            bbiParameters.ButtonStyle = BarButtonStyle.Check;
            bbiParameters.Caption = "Parameters";
            bbiParameters.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters;
            bbiParameters.Enabled = false;
            bbiParameters.Hint = "Parameters";
            bbiParameters.Id = 6;
            bbiParameters.Name = "bbiParameters";
            // 
            // bbiThumbnails
            // 
            bbiThumbnails.ButtonStyle = BarButtonStyle.Check;
            bbiThumbnails.Caption = "Thumbnails";
            bbiThumbnails.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails;
            bbiThumbnails.Enabled = false;
            bbiThumbnails.Hint = "Thumbnails";
            bbiThumbnails.Id = 7;
            bbiThumbnails.Name = "bbiThumbnails";
            // 
            // bbiFind
            // 
            bbiFind.ButtonStyle = BarButtonStyle.Check;
            bbiFind.Caption = "Search";
            bbiFind.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find;
            bbiFind.Enabled = false;
            bbiFind.Hint = "Search";
            bbiFind.Id = 8;
            bbiFind.Name = "bbiFind";
            // 
            // bbiHighlightEditingFields
            // 
            bbiHighlightEditingFields.ButtonStyle = BarButtonStyle.Check;
            bbiHighlightEditingFields.Caption = "Editing Fields";
            bbiHighlightEditingFields.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields;
            bbiHighlightEditingFields.Enabled = false;
            bbiHighlightEditingFields.Hint = "Highlight Editing Fields";
            bbiHighlightEditingFields.Id = 9;
            bbiHighlightEditingFields.Name = "bbiHighlightEditingFields";
            // 
            // bbiCustomize
            // 
            bbiCustomize.Caption = "Customize";
            bbiCustomize.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize;
            bbiCustomize.Enabled = false;
            bbiCustomize.Hint = "Customize";
            bbiCustomize.Id = 10;
            bbiCustomize.Name = "bbiCustomize";
            // 
            // bbiOpen
            // 
            bbiOpen.Caption = "Open";
            bbiOpen.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open;
            bbiOpen.Enabled = false;
            bbiOpen.Hint = "Open a document";
            bbiOpen.Id = 11;
            bbiOpen.Name = "bbiOpen";
            // 
            // bbiSave
            // 
            bbiSave.Caption = "Save";
            bbiSave.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save;
            bbiSave.Enabled = false;
            bbiSave.Hint = "Save the document";
            bbiSave.Id = 12;
            bbiSave.Name = "bbiSave";
            // 
            // bbiPrint
            // 
            bbiPrint.Caption = "&Print...";
            bbiPrint.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
            bbiPrint.Enabled = false;
            bbiPrint.Hint = "Print";
            bbiPrint.Id = 13;
            bbiPrint.Name = "bbiPrint";
            // 
            // bbiPrintDirect
            // 
            bbiPrintDirect.Caption = "P&rint";
            bbiPrintDirect.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
            bbiPrintDirect.Enabled = false;
            bbiPrintDirect.Hint = "Quick Print";
            bbiPrintDirect.Id = 14;
            bbiPrintDirect.Name = "bbiPrintDirect";
            // 
            // bbiPageSetup
            // 
            bbiPageSetup.Caption = "Page Set&up...";
            bbiPageSetup.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup;
            bbiPageSetup.Enabled = false;
            bbiPageSetup.Hint = "Page Setup";
            bbiPageSetup.Id = 15;
            bbiPageSetup.Name = "bbiPageSetup";
            // 
            // bbiEditPageHF
            // 
            bbiEditPageHF.Caption = "Header And Footer";
            bbiEditPageHF.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF;
            bbiEditPageHF.Enabled = false;
            bbiEditPageHF.Hint = "Header And Footer";
            bbiEditPageHF.Id = 16;
            bbiEditPageHF.Name = "bbiEditPageHF";
            // 
            // bbiScale
            // 
            bbiScale.ActAsDropDown = true;
            bbiScale.ButtonStyle = BarButtonStyle.DropDown;
            bbiScale.Caption = "Scale";
            bbiScale.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale;
            bbiScale.Enabled = false;
            bbiScale.Hint = "Scale";
            bbiScale.Id = 17;
            bbiScale.Name = "bbiScale";
            // 
            // bbiHandTool
            // 
            bbiHandTool.ButtonStyle = BarButtonStyle.Check;
            bbiHandTool.Caption = "Hand Tool";
            bbiHandTool.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool;
            bbiHandTool.Enabled = false;
            bbiHandTool.Hint = "Hand Tool";
            bbiHandTool.Id = 18;
            bbiHandTool.Name = "bbiHandTool";
            // 
            // bbiMagnifier
            // 
            bbiMagnifier.ButtonStyle = BarButtonStyle.Check;
            bbiMagnifier.Caption = "Magnifier";
            bbiMagnifier.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier;
            bbiMagnifier.Enabled = false;
            bbiMagnifier.Hint = "Magnifier";
            bbiMagnifier.Id = 19;
            bbiMagnifier.Name = "bbiMagnifier";
            // 
            // bbiZoomOut
            // 
            bbiZoomOut.Caption = "Zoom Out";
            bbiZoomOut.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut;
            bbiZoomOut.Enabled = false;
            bbiZoomOut.Hint = "Zoom Out";
            bbiZoomOut.Id = 20;
            bbiZoomOut.Name = "bbiZoomOut";
            // 
            // bbiZoom
            // 
            bbiZoom.Caption = "Zoom";
            bbiZoom.Edit = printPreviewRepositoryItemComboBox1;
            bbiZoom.EditValue = "100%";
            bbiZoom.EditWidth = 70;
            bbiZoom.Enabled = false;
            bbiZoom.Hint = "Zoom";
            bbiZoom.Id = 21;
            bbiZoom.Name = "bbiZoom";
            // 
            // printPreviewRepositoryItemComboBox1
            // 
            printPreviewRepositoryItemComboBox1.AutoComplete = false;
            printPreviewRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            printPreviewRepositoryItemComboBox1.DropDownRows = 11;
            printPreviewRepositoryItemComboBox1.Name = "printPreviewRepositoryItemComboBox1";
            // 
            // bbiZoomIn
            // 
            bbiZoomIn.Caption = "Zoom In";
            bbiZoomIn.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn;
            bbiZoomIn.Enabled = false;
            bbiZoomIn.Hint = "Zoom In";
            bbiZoomIn.Id = 22;
            bbiZoomIn.Name = "bbiZoomIn";
            // 
            // bbiShowFirstPage
            // 
            bbiShowFirstPage.Caption = "First Page";
            bbiShowFirstPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
            bbiShowFirstPage.Enabled = false;
            bbiShowFirstPage.Hint = "First Page";
            bbiShowFirstPage.Id = 23;
            bbiShowFirstPage.Name = "bbiShowFirstPage";
            // 
            // bbiShowPrevPage
            // 
            bbiShowPrevPage.Caption = "Previous Page";
            bbiShowPrevPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
            bbiShowPrevPage.Enabled = false;
            bbiShowPrevPage.Hint = "Previous Page";
            bbiShowPrevPage.Id = 24;
            bbiShowPrevPage.Name = "bbiShowPrevPage";
            // 
            // bbiShowNextPage
            // 
            bbiShowNextPage.Caption = "Next Page";
            bbiShowNextPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
            bbiShowNextPage.Enabled = false;
            bbiShowNextPage.Hint = "Next Page";
            bbiShowNextPage.Id = 25;
            bbiShowNextPage.Name = "bbiShowNextPage";
            // 
            // bbiShowLastPage
            // 
            bbiShowLastPage.Caption = "Last Page";
            bbiShowLastPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
            bbiShowLastPage.Enabled = false;
            bbiShowLastPage.Hint = "Last Page";
            bbiShowLastPage.Id = 26;
            bbiShowLastPage.Name = "bbiShowLastPage";
            // 
            // bbiMultiplePages
            // 
            bbiMultiplePages.ButtonStyle = BarButtonStyle.DropDown;
            bbiMultiplePages.Caption = "Multiple Pages";
            bbiMultiplePages.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages;
            bbiMultiplePages.Enabled = false;
            bbiMultiplePages.Hint = "Multiple Pages";
            bbiMultiplePages.Id = 27;
            bbiMultiplePages.Name = "bbiMultiplePages";
            // 
            // bbiFillBackground
            // 
            bbiFillBackground.ButtonStyle = BarButtonStyle.DropDown;
            bbiFillBackground.Caption = "&Color...";
            bbiFillBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground;
            bbiFillBackground.Enabled = false;
            bbiFillBackground.Hint = "Background";
            bbiFillBackground.Id = 28;
            bbiFillBackground.Name = "bbiFillBackground";
            // 
            // bbiWatermark
            // 
            bbiWatermark.Caption = "&Watermark...";
            bbiWatermark.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark;
            bbiWatermark.Enabled = false;
            bbiWatermark.Hint = "Watermark";
            bbiWatermark.Id = 29;
            bbiWatermark.Name = "bbiWatermark";
            // 
            // bbiExportFile
            // 
            bbiExportFile.ButtonStyle = BarButtonStyle.DropDown;
            bbiExportFile.Caption = "Export Document...";
            bbiExportFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile;
            bbiExportFile.Enabled = false;
            bbiExportFile.Hint = "Export Document...";
            bbiExportFile.Id = 30;
            bbiExportFile.Name = "bbiExportFile";
            // 
            // bbiSendFile
            // 
            bbiSendFile.ButtonStyle = BarButtonStyle.DropDown;
            bbiSendFile.Caption = "Send via E-Mail...";
            bbiSendFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile;
            bbiSendFile.Enabled = false;
            bbiSendFile.Hint = "Send via E-Mail...";
            bbiSendFile.Id = 31;
            bbiSendFile.Name = "bbiSendFile";
            // 
            // bbiClosePreview
            // 
            bbiClosePreview.Caption = "E&xit";
            bbiClosePreview.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview;
            bbiClosePreview.Enabled = false;
            bbiClosePreview.Hint = "Close Preview";
            bbiClosePreview.Id = 32;
            bbiClosePreview.Name = "bbiClosePreview";
            // 
            // miFile
            // 
            miFile.Caption = "&File";
            miFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File;
            miFile.Id = 33;
            miFile.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(bbiPageSetup), new LinkPersistInfo(bbiPrint), new LinkPersistInfo(bbiPrintDirect), new LinkPersistInfo(bbiExportFile, true), new LinkPersistInfo(bbiSendFile), new LinkPersistInfo(bbiClosePreview, true) });
            miFile.Name = "miFile";
            // 
            // miView
            // 
            miView.Caption = "&View";
            miView.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View;
            miView.Id = 34;
            miView.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(miPageLayout, true), new LinkPersistInfo(miToolbars, true) });
            miView.Name = "miView";
            // 
            // miBackground
            // 
            miBackground.Caption = "&Background";
            miBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background;
            miBackground.Id = 35;
            miBackground.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(bbiFillBackground), new LinkPersistInfo(bbiWatermark) });
            miBackground.Name = "miBackground";
            // 
            // miPageLayout
            // 
            miPageLayout.Caption = "&Page Layout";
            miPageLayout.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout;
            miPageLayout.Id = 36;
            miPageLayout.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(miPageLayoutFacing), new LinkPersistInfo(miPageLayoutContinuous) });
            miPageLayout.Name = "miPageLayout";
            // 
            // miPageLayoutFacing
            // 
            miPageLayoutFacing.ButtonStyle = BarButtonStyle.Check;
            miPageLayoutFacing.Caption = "&Facing";
            miPageLayoutFacing.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing;
            miPageLayoutFacing.Enabled = false;
            miPageLayoutFacing.GroupIndex = 100;
            miPageLayoutFacing.Id = 37;
            miPageLayoutFacing.Name = "miPageLayoutFacing";
            // 
            // miPageLayoutContinuous
            // 
            miPageLayoutContinuous.ButtonStyle = BarButtonStyle.Check;
            miPageLayoutContinuous.Caption = "&Continuous";
            miPageLayoutContinuous.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous;
            miPageLayoutContinuous.Enabled = false;
            miPageLayoutContinuous.GroupIndex = 100;
            miPageLayoutContinuous.Id = 38;
            miPageLayoutContinuous.Name = "miPageLayoutContinuous";
            // 
            // miToolbars
            // 
            miToolbars.Caption = "Bars";
            miToolbars.Id = 39;
            miToolbars.Name = "miToolbars";
            // 
            // printPreviewBarCheckItem1
            // 
            printPreviewBarCheckItem1.BindableChecked = true;
            printPreviewBarCheckItem1.Caption = "PDF File";
            printPreviewBarCheckItem1.Checked = true;
            printPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf;
            printPreviewBarCheckItem1.Enabled = false;
            printPreviewBarCheckItem1.GroupIndex = 2;
            printPreviewBarCheckItem1.Hint = "PDF File";
            printPreviewBarCheckItem1.Id = 40;
            printPreviewBarCheckItem1.Name = "printPreviewBarCheckItem1";
            // 
            // printPreviewBarCheckItem2
            // 
            printPreviewBarCheckItem2.Caption = "HTML File";
            printPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm;
            printPreviewBarCheckItem2.Enabled = false;
            printPreviewBarCheckItem2.GroupIndex = 2;
            printPreviewBarCheckItem2.Hint = "HTML File";
            printPreviewBarCheckItem2.Id = 41;
            printPreviewBarCheckItem2.Name = "printPreviewBarCheckItem2";
            // 
            // printPreviewBarCheckItem3
            // 
            printPreviewBarCheckItem3.Caption = "MHT File";
            printPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht;
            printPreviewBarCheckItem3.Enabled = false;
            printPreviewBarCheckItem3.GroupIndex = 2;
            printPreviewBarCheckItem3.Hint = "MHT File";
            printPreviewBarCheckItem3.Id = 42;
            printPreviewBarCheckItem3.Name = "printPreviewBarCheckItem3";
            // 
            // printPreviewBarCheckItem4
            // 
            printPreviewBarCheckItem4.Caption = "RTF File";
            printPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf;
            printPreviewBarCheckItem4.Enabled = false;
            printPreviewBarCheckItem4.GroupIndex = 2;
            printPreviewBarCheckItem4.Hint = "RTF File";
            printPreviewBarCheckItem4.Id = 43;
            printPreviewBarCheckItem4.Name = "printPreviewBarCheckItem4";
            // 
            // printPreviewBarCheckItem5
            // 
            printPreviewBarCheckItem5.Caption = "DOCX File";
            printPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportDocx;
            printPreviewBarCheckItem5.Enabled = false;
            printPreviewBarCheckItem5.GroupIndex = 2;
            printPreviewBarCheckItem5.Hint = "DOCX File";
            printPreviewBarCheckItem5.Id = 44;
            printPreviewBarCheckItem5.Name = "printPreviewBarCheckItem5";
            // 
            // printPreviewBarCheckItem6
            // 
            printPreviewBarCheckItem6.Caption = "XLS File";
            printPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls;
            printPreviewBarCheckItem6.Enabled = false;
            printPreviewBarCheckItem6.GroupIndex = 2;
            printPreviewBarCheckItem6.Hint = "XLS File";
            printPreviewBarCheckItem6.Id = 45;
            printPreviewBarCheckItem6.Name = "printPreviewBarCheckItem6";
            // 
            // printPreviewBarCheckItem7
            // 
            printPreviewBarCheckItem7.Caption = "XLSX File";
            printPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx;
            printPreviewBarCheckItem7.Enabled = false;
            printPreviewBarCheckItem7.GroupIndex = 2;
            printPreviewBarCheckItem7.Hint = "XLSX File";
            printPreviewBarCheckItem7.Id = 46;
            printPreviewBarCheckItem7.Name = "printPreviewBarCheckItem7";
            // 
            // printPreviewBarCheckItem8
            // 
            printPreviewBarCheckItem8.Caption = "CSV File";
            printPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv;
            printPreviewBarCheckItem8.Enabled = false;
            printPreviewBarCheckItem8.GroupIndex = 2;
            printPreviewBarCheckItem8.Hint = "CSV File";
            printPreviewBarCheckItem8.Id = 47;
            printPreviewBarCheckItem8.Name = "printPreviewBarCheckItem8";
            // 
            // printPreviewBarCheckItem9
            // 
            printPreviewBarCheckItem9.Caption = "Text File";
            printPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt;
            printPreviewBarCheckItem9.Enabled = false;
            printPreviewBarCheckItem9.GroupIndex = 2;
            printPreviewBarCheckItem9.Hint = "Text File";
            printPreviewBarCheckItem9.Id = 48;
            printPreviewBarCheckItem9.Name = "printPreviewBarCheckItem9";
            // 
            // printPreviewBarCheckItem10
            // 
            printPreviewBarCheckItem10.Caption = "Image File";
            printPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic;
            printPreviewBarCheckItem10.Enabled = false;
            printPreviewBarCheckItem10.GroupIndex = 2;
            printPreviewBarCheckItem10.Hint = "Image File";
            printPreviewBarCheckItem10.Id = 49;
            printPreviewBarCheckItem10.Name = "printPreviewBarCheckItem10";
            // 
            // printPreviewBarCheckItem11
            // 
            printPreviewBarCheckItem11.BindableChecked = true;
            printPreviewBarCheckItem11.Caption = "PDF File";
            printPreviewBarCheckItem11.Checked = true;
            printPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf;
            printPreviewBarCheckItem11.Enabled = false;
            printPreviewBarCheckItem11.GroupIndex = 1;
            printPreviewBarCheckItem11.Hint = "PDF File";
            printPreviewBarCheckItem11.Id = 50;
            printPreviewBarCheckItem11.Name = "printPreviewBarCheckItem11";
            // 
            // printPreviewBarCheckItem12
            // 
            printPreviewBarCheckItem12.Caption = "MHT File";
            printPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht;
            printPreviewBarCheckItem12.Enabled = false;
            printPreviewBarCheckItem12.GroupIndex = 1;
            printPreviewBarCheckItem12.Hint = "MHT File";
            printPreviewBarCheckItem12.Id = 51;
            printPreviewBarCheckItem12.Name = "printPreviewBarCheckItem12";
            // 
            // printPreviewBarCheckItem13
            // 
            printPreviewBarCheckItem13.Caption = "RTF File";
            printPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf;
            printPreviewBarCheckItem13.Enabled = false;
            printPreviewBarCheckItem13.GroupIndex = 1;
            printPreviewBarCheckItem13.Hint = "RTF File";
            printPreviewBarCheckItem13.Id = 52;
            printPreviewBarCheckItem13.Name = "printPreviewBarCheckItem13";
            // 
            // printPreviewBarCheckItem14
            // 
            printPreviewBarCheckItem14.Caption = "DOCX File";
            printPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendDocx;
            printPreviewBarCheckItem14.Enabled = false;
            printPreviewBarCheckItem14.GroupIndex = 1;
            printPreviewBarCheckItem14.Hint = "DOCX File";
            printPreviewBarCheckItem14.Id = 53;
            printPreviewBarCheckItem14.Name = "printPreviewBarCheckItem14";
            // 
            // printPreviewBarCheckItem15
            // 
            printPreviewBarCheckItem15.Caption = "XLS File";
            printPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls;
            printPreviewBarCheckItem15.Enabled = false;
            printPreviewBarCheckItem15.GroupIndex = 1;
            printPreviewBarCheckItem15.Hint = "XLS File";
            printPreviewBarCheckItem15.Id = 54;
            printPreviewBarCheckItem15.Name = "printPreviewBarCheckItem15";
            // 
            // printPreviewBarCheckItem16
            // 
            printPreviewBarCheckItem16.Caption = "XLSX File";
            printPreviewBarCheckItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx;
            printPreviewBarCheckItem16.Enabled = false;
            printPreviewBarCheckItem16.GroupIndex = 1;
            printPreviewBarCheckItem16.Hint = "XLSX File";
            printPreviewBarCheckItem16.Id = 55;
            printPreviewBarCheckItem16.Name = "printPreviewBarCheckItem16";
            // 
            // printPreviewBarCheckItem17
            // 
            printPreviewBarCheckItem17.Caption = "CSV File";
            printPreviewBarCheckItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv;
            printPreviewBarCheckItem17.Enabled = false;
            printPreviewBarCheckItem17.GroupIndex = 1;
            printPreviewBarCheckItem17.Hint = "CSV File";
            printPreviewBarCheckItem17.Id = 56;
            printPreviewBarCheckItem17.Name = "printPreviewBarCheckItem17";
            // 
            // printPreviewBarCheckItem18
            // 
            printPreviewBarCheckItem18.Caption = "Text File";
            printPreviewBarCheckItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt;
            printPreviewBarCheckItem18.Enabled = false;
            printPreviewBarCheckItem18.GroupIndex = 1;
            printPreviewBarCheckItem18.Hint = "Text File";
            printPreviewBarCheckItem18.Id = 57;
            printPreviewBarCheckItem18.Name = "printPreviewBarCheckItem18";
            // 
            // printPreviewBarCheckItem19
            // 
            printPreviewBarCheckItem19.Caption = "Image File";
            printPreviewBarCheckItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic;
            printPreviewBarCheckItem19.Enabled = false;
            printPreviewBarCheckItem19.GroupIndex = 1;
            printPreviewBarCheckItem19.Hint = "Image File";
            printPreviewBarCheckItem19.Id = 58;
            printPreviewBarCheckItem19.Name = "printPreviewBarCheckItem19";
            // 
            // frmRevenueReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 360);
            Controls.Add(documentViewer);
            Controls.Add(panelControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "frmRevenueReportViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revenue Report Viewer";
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)documentViewerBarManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemProgressBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemZoomTrackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)printPreviewRepositoryItemComboBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraEditors.DateEdit dateEditTo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnViewReport;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer;
        private DocumentViewerBarManager documentViewerBarManager1;
        private PreviewBar previewBar1;
        private PrintPreviewBarItem bbiDocumentMap;
        private PrintPreviewBarItem bbiParameters;
        private PrintPreviewBarItem bbiThumbnails;
        private PrintPreviewBarItem bbiFind;
        private PrintPreviewBarItem bbiHighlightEditingFields;
        private PrintPreviewBarItem bbiCustomize;
        private PrintPreviewBarItem bbiOpen;
        private PrintPreviewBarItem bbiSave;
        private PrintPreviewBarItem bbiPrint;
        private PrintPreviewBarItem bbiPrintDirect;
        private PrintPreviewBarItem bbiPageSetup;
        private PrintPreviewBarItem bbiEditPageHF;
        private PrintPreviewBarItem bbiScale;
        private PrintPreviewBarItem bbiHandTool;
        private PrintPreviewBarItem bbiMagnifier;
        private PrintPreviewBarItem bbiZoomOut;
        private ZoomBarEditItem bbiZoom;
        private PrintPreviewRepositoryItemComboBox printPreviewRepositoryItemComboBox1;
        private PrintPreviewBarItem bbiZoomIn;
        private PrintPreviewBarItem bbiShowFirstPage;
        private PrintPreviewBarItem bbiShowPrevPage;
        private PrintPreviewBarItem bbiShowNextPage;
        private PrintPreviewBarItem bbiShowLastPage;
        private PrintPreviewBarItem bbiMultiplePages;
        private PrintPreviewBarItem bbiFillBackground;
        private PrintPreviewBarItem bbiWatermark;
        private PrintPreviewBarItem bbiExportFile;
        private PrintPreviewBarItem bbiSendFile;
        private PrintPreviewBarItem bbiClosePreview;
        private PreviewBar previewBar2;
        private PrintPreviewStaticItem printPreviewStaticItemPageOfPages;
        private ProgressBarEditItem progressBarEditItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private PrintPreviewBarItem printPreviewBarItem1;
        private PrintPreviewStaticItem printPreviewStaticItemZoomFactor;
        private ZoomTrackBarEditItem zoomTrackBarEditItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private PrintPreviewSubItem miFile;
        private PrintPreviewSubItem miView;
        private PrintPreviewSubItem miPageLayout;
        private PrintPreviewBarItem miPageLayoutFacing;
        private PrintPreviewBarItem miPageLayoutContinuous;
        private BarToolbarsListItem miToolbars;
        private PrintPreviewSubItem miBackground;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem1;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem2;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem3;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem4;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem5;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem6;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem7;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem8;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem9;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem10;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem11;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem12;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem13;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem14;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem15;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem16;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem17;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem18;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem19;
    }
}