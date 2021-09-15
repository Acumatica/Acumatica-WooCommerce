<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormTab.master" AutoEventWireup="true"
	ValidateRequest="false" CodeFile="BC201020.aspx.cs" Inherits="Page_BC201020" Title="Untitled Page" %>

<%@ MasterType VirtualPath="~/MasterPages/FormTab.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource PageLoadBehavior="GoFirstRecord" ID="ds" runat="server" Visible="" Width="100%" PrimaryView="Bindings" TypeName="WooCommerceConnector.WooCommerceStoreMaint">

		<CallbackCommands>
		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
	<px:PXFormView ID="form" runat="server" DataSourceID="ds" Style="z-index: 100" Width="100%" DataMember="Bindings" TabIndex="6500">
		<Template>
			<px:PXLayoutRule runat="server" StartRow="True" ControlSize="L" LabelsWidth="SM"></px:PXLayoutRule>
			<px:PXDropDown AllowEdit="False" CommitChanges="True" runat="server" ID="CstPXDropDown16" DataField="ConnectorType"></px:PXDropDown>
			<px:PXSelector AutoRefresh="True" AllowEdit="False" CommitChanges="True" runat="server" ID="CstPXSelector17" DataField="BindingName"></px:PXSelector>
			<px:PXLayoutRule runat="server" ID="CstPXLayoutRule69" StartColumn="True" />
			<px:PXCheckBox CommitChanges="True" AlignLeft="True" runat="server" ID="CstPXCheckBox67" DataField="IsActive"></px:PXCheckBox>
			<px:PXCheckBox AlignLeft="True" runat="server" ID="CstPXCheckBox68" DataField="IsDefault"></px:PXCheckBox>
		</Template>
	</px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
	<px:PXTab ID="tab" runat="server" Width="100%" Height="150px" DataSourceID="ds" DataMember="CurrentStore">
		<Items>
			<px:PXTabItem Text="Entity Settings">
				<Template>
					<px:PXGrid MatrixMode="True" runat="server" SkinID="Details" Width="100%" ID="CstPXGrid60">
						<AutoSize Enabled="True" Container="Window"></AutoSize>
						<ActionBar DefaultAction="navigate">
							<Actions>
								<AddNew ToolBarVisible="False"></AddNew>
								<Delete ToolBarVisible="False"></Delete>
								<ExportExcel ToolBarVisible="False"></ExportExcel>
							</Actions>
						</ActionBar>
						<Levels>
							<px:PXGridLevel DataMember="Entities">
								<Columns>
									<px:PXGridColumn Type="CheckBox" TextAlign="Center" DataField="IsActive" Width="60" CommitChanges="True"></px:PXGridColumn>
									<px:PXGridColumn LinkCommand="Navigate" DataField="EntityType" Width="70"></px:PXGridColumn>
									<px:PXGridColumn CommitChanges="True" DataField="Direction" Width="70"></px:PXGridColumn>
									<px:PXGridColumn CommitChanges="True" DataField="PrimarySystem" Width="70"></px:PXGridColumn>
									<px:PXGridColumn DataField="ImportRealTimeStatus" Width="120"></px:PXGridColumn>
									<px:PXGridColumn DataField="ExportRealTimeStatus" Width="120"></px:PXGridColumn>
									<px:PXGridColumn TextAlign="Center" DataField="AutoSyncNotification" Width="100" Type="CheckBox"></px:PXGridColumn>
									<px:PXGridColumn DataField="MaxAttemptCount" Width="150"></px:PXGridColumn>
								</Columns>
								<RowTemplate>
									<px:PXNumberEdit runat="server" ID="CstPXNumberEdit70" DataField="MaxAttemptCount"></px:PXNumberEdit>
								</RowTemplate>
							</px:PXGridLevel>
						</Levels>
					</px:PXGrid>
				</Template>
			</px:PXTabItem>
		</Items>
		<AutoSize Container="Window" Enabled="True" MinHeight="150"></AutoSize>
	</px:PXTab>
</asp:Content>
