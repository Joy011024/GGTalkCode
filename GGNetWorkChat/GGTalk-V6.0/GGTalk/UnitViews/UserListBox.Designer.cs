namespace GGTalk.UnitViews
{
    partial class UserListBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chatListBox = new CCWin.SkinControl.ChatListBox();
            this.skinContextMenuStrip_user = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
            this.recordHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGoupMenuItem = new CCWin.SkinControl.SkinContextMenuStrip();
            this.changeGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinContextMenuStrip_user.SuspendLayout();
            this.cmsGoupMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox
            // 
            this.chatListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox.DrawContentType = CCWin.SkinControl.DrawContentType.PersonalMsg;
            this.chatListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox.ForeColor = System.Drawing.Color.Black;
            this.chatListBox.FriendsMobile = true;
            this.chatListBox.ListHadOpenGroup = null;
            this.chatListBox.ListSubItemMenu = this.skinContextMenuStrip_user;
            this.chatListBox.Location = new System.Drawing.Point(0, 0);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.SelectSubItem = null;
            this.chatListBox.ShowNicName = false;
            this.chatListBox.Size = new System.Drawing.Size(136, 369);
            this.chatListBox.SubItemMenu = this.cmsGoupMenuItem;
            this.chatListBox.TabIndex = 0;
            this.chatListBox.Text = "chatListBox1";
            this.chatListBox.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.chatListBox_DoubleClickSubItem);
            this.chatListBox.MouseEnterHead += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.chatShow_MouseEnterHead);
            this.chatListBox.MouseLeaveHead += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.chatShow_MouseLeaveHead);
            this.chatListBox.DragSubItemDrop += new CCWin.SkinControl.ChatListBox.DragListEventHandler(this.chatListBox_DragSubItemDrop);
            // 
            // skinContextMenuStrip_user
            // 
            this.skinContextMenuStrip_user.Arrow = System.Drawing.Color.Gray;
            this.skinContextMenuStrip_user.Back = System.Drawing.Color.White;
            this.skinContextMenuStrip_user.BackRadius = 4;
            this.skinContextMenuStrip_user.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinContextMenuStrip_user.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinContextMenuStrip_user.Fore = System.Drawing.Color.Black;
            this.skinContextMenuStrip_user.HoverFore = System.Drawing.Color.White;
            this.skinContextMenuStrip_user.ImageScalingSize = new System.Drawing.Size(11, 11);
            this.skinContextMenuStrip_user.ItemAnamorphosis = false;
            this.skinContextMenuStrip_user.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_user.ItemBorderShow = false;
            this.skinContextMenuStrip_user.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_user.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_user.ItemRadius = 4;
            this.skinContextMenuStrip_user.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinContextMenuStrip_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem51,
            this.recordHistoryToolStripMenuItem,
            this.DeleteFriendToolStripMenuItem});
            this.skinContextMenuStrip_user.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinContextMenuStrip_user.Name = "MenuState";
            this.skinContextMenuStrip_user.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip_user.Size = new System.Drawing.Size(125, 70);
            this.skinContextMenuStrip_user.SkinAllColor = true;
            this.skinContextMenuStrip_user.TitleAnamorphosis = false;
            this.skinContextMenuStrip_user.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinContextMenuStrip_user.TitleRadius = 4;
            this.skinContextMenuStrip_user.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem51.Tag = "1";
            this.toolStripMenuItem51.Text = "发送消息";
            this.toolStripMenuItem51.ToolTipText = "表示希望好友看到您在线。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.toolStripMenuItem51.Click += new System.EventHandler(this.toolStripMenuItem51_Click);
            // 
            // recordHistoryToolStripMenuItem
            // 
            this.recordHistoryToolStripMenuItem.Name = "recordHistoryToolStripMenuItem";
            this.recordHistoryToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.recordHistoryToolStripMenuItem.Text = "消息记录";
            this.recordHistoryToolStripMenuItem.Click += new System.EventHandler(this.消息记录ToolStripMenuItem_Click);
            // 
            // DeleteFriendToolStripMenuItem
            // 
            this.DeleteFriendToolStripMenuItem.Name = "DeleteFriendToolStripMenuItem";
            this.DeleteFriendToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DeleteFriendToolStripMenuItem.Text = "删除好友";
            this.DeleteFriendToolStripMenuItem.Click += new System.EventHandler(this.删除好友ToolStripMenuItem_Click);
            // 
            // cmsGoupMenuItem
            // 
            this.cmsGoupMenuItem.Arrow = System.Drawing.Color.Black;
            this.cmsGoupMenuItem.Back = System.Drawing.Color.White;
            this.cmsGoupMenuItem.BackRadius = 4;
            this.cmsGoupMenuItem.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.cmsGoupMenuItem.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cmsGoupMenuItem.Fore = System.Drawing.Color.Black;
            this.cmsGoupMenuItem.HoverFore = System.Drawing.Color.White;
            this.cmsGoupMenuItem.ItemAnamorphosis = true;
            this.cmsGoupMenuItem.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cmsGoupMenuItem.ItemBorderShow = true;
            this.cmsGoupMenuItem.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cmsGoupMenuItem.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cmsGoupMenuItem.ItemRadius = 4;
            this.cmsGoupMenuItem.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cmsGoupMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeGroupToolStripMenuItem,
            this.addGroupToolStripMenuItem,
            this.deleteGroupToolStripMenuItem});
            this.cmsGoupMenuItem.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cmsGoupMenuItem.Name = "skinContextMenuStrip1";
            this.cmsGoupMenuItem.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cmsGoupMenuItem.Size = new System.Drawing.Size(181, 92);
            this.cmsGoupMenuItem.SkinAllColor = true;
            this.cmsGoupMenuItem.TitleAnamorphosis = true;
            this.cmsGoupMenuItem.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.cmsGoupMenuItem.TitleRadius = 4;
            this.cmsGoupMenuItem.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // changeGroupToolStripMenuItem
            // 
            this.changeGroupToolStripMenuItem.Name = "changeGroupToolStripMenuItem";
            this.changeGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeGroupToolStripMenuItem.Text = "修改组名";
            this.changeGroupToolStripMenuItem.Click += new System.EventHandler(this.修改名称ToolStripMenuItem_Click);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addGroupToolStripMenuItem.Text = "添加分组";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.添加分组ToolStripMenuItem_Click);
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteGroupToolStripMenuItem.Text = "删除分组";
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.删除分组ToolStripMenuItem_Click);
            // 
            // UserListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chatListBox);
            this.Name = "UserListBox";
            this.Size = new System.Drawing.Size(136, 369);
            this.skinContextMenuStrip_user.ResumeLayout(false);
            this.cmsGoupMenuItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.ChatListBox chatListBox;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip_user;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem51;
        private System.Windows.Forms.ToolStripMenuItem recordHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteFriendToolStripMenuItem;
        private CCWin.SkinControl.SkinContextMenuStrip cmsGoupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;

    }
}
