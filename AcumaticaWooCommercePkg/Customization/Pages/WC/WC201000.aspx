<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormTab.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="WC201000.aspx.cs" Inherits="Page_WC201000" Title="Untitled Page" %>

<%@ MasterType VirtualPath="~/MasterPages/FormTab.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
    <px:PXDataSource PageLoadBehavior="GoFirstRecord" ID="ds" runat="server" Visible="True" Width="100%"
        TypeName="PX.Commerce.WooCommerce.WCStoreMaint"
        PrimaryView="Bindings">
        <CallbackCommands>
        </CallbackCommands>
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
    <px:PXFormView ID="form" runat="server" DataSourceID="ds" DataMember="Bindings" Width="100%" Height="100px" AllowAutoHide="false">
        <Template>
            <px:PXLayoutRule ID="PXLayoutRule1" runat="server" StartRow="True"></px:PXLayoutRule>
            <px:PXDropDown runat="server" ID="CstPXDropDown10" DataField="ConnectorType" />
            <px:PXSelector runat="server" ID="CstPXSelector9" DataField="BindingName" />
            <px:PXLayoutRule runat="server" ID="CstPXLayoutRule13" StartColumn="True" />
            <px:PXCheckBox runat="server" ID="CstPXCheckBox11" DataField="IsActive" />
            <px:PXCheckBox runat="server" ID="CstPXCheckBox12" DataField="IsDefault" />
        </Template>
    </px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
    <px:PXTab DataMember="CurrentStore" ID="tab" runat="server" Width="100%" Height="150px" DataSourceID="ds" AllowAutoHide="false">
        <Items>
            <px:PXTabItem Text="Connection Settings">
                <Template>
                    <px:PXLayoutRule runat="server" ID="CstLayoutRule26" StartColumn="True"></px:PXLayoutRule>
                    <px:PXFormView runat="server" ID="CstFormView14" DataMember="CurrentBindingWooCommerce">
                        <Template>
                            <px:PXLayoutRule runat="server" ID="CstLayoutRule23" ColumnWidth="XL" LabelsWidth="SM" StartRow="True" StartColumn="True"></px:PXLayoutRule>
                            <px:PXTextEdit runat="server" ID="CstPXTextEdit15" DataField="StoreAdminUrl"></px:PXTextEdit>
                            <px:PXLayoutRule GroupCaption="REST Settings" ColumnWidth="XL" LabelsWidth="SM" StartGroup="True" runat="server" ID="CstLayoutRule24"></px:PXLayoutRule>
                            <px:PXTextEdit runat="server" ID="CstPXTextEdit16" DataField="StoreBaseUrl"></px:PXTextEdit>
                            <px:PXTextEdit runat="server" ID="CstPXTextEdit17" DataField="StoreXAuthClient"></px:PXTextEdit>
                            <px:PXTextEdit runat="server" ID="CstPXTextEdit18" DataField="StoreXAuthToken"></px:PXTextEdit>
                            <px:PXLayoutRule runat="server" ID="CstLayoutRule25"></px:PXLayoutRule>
                        </Template>
                    </px:PXFormView>
                    <px:PXLayoutRule GroupCaption="Store Properties" runat="server" ID="CstPXLayoutRule29" StartRow="True"></px:PXLayoutRule>
                    <px:PXFormView runat="server" ID="CstFormView30" DataMember="CurrentBindingWooCommerce" RenderStyle="Simple">
                        <Template>
                            <px:PXTextEdit runat="server" ID="CstPXTextEdit31" DataField="WooCommerceDefaultCurrency"></px:PXTextEdit>
                            <px:PXTextEdit runat="server" ID="CstPXTextEdit32" DataField="WooCommerceStoreTimeZone"></px:PXTextEdit>
                        </Template>
                    </px:PXFormView>
                </Template>
            </px:PXTabItem>
            <px:PXTabItem Text="Entity Settings">
                <Template>
                    <px:PXGrid runat="server" ID="CstPXGrid42">
                        <Levels>
                            <px:PXGridLevel DataMember="Entities">
                                <Columns>
                                    <px:PXGridColumn Type="CheckBox" CommitChanges="True" DataField="IsActive" Width="60"></px:PXGridColumn>
                                    <px:PXGridColumn LinkCommand="Navigate" DataField="EntityType" Width="70"></px:PXGridColumn>
                                    <px:PXGridColumn CommitChanges="True" DataField="Direction" Width="70"></px:PXGridColumn>
                                    <px:PXGridColumn CommitChanges="True" DataField="PrimarySystem" Width="120"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="ImportRealTimeStatus" Width="120"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="ExportRealTimeStatus" Width="120"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="RealTimeMode" Width="130"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="MaxAttemptCount" Width="120"></px:PXGridColumn>
                                </Columns>
                            </px:PXGridLevel>
                        </Levels>
                        <ActionBar>
                            <Actions>
                                <AddNew ToolBarVisible="False"></AddNew>
                                <Delete ToolBarVisible="False"></Delete>
                                <ExportExcel ToolBarVisible="False"></ExportExcel>
                            </Actions>
                        </ActionBar>
                    </px:PXGrid>
                </Template>
            </px:PXTabItem>
            <px:PXTabItem Text="Customer Settings">
                <Template>
                    <px:PXLayoutRule runat="server" ID="CstPXLayoutRule44" StartColumn="True" StartGroup="False" ColumnWidth="M" LabelsWidth="M"></px:PXLayoutRule>
                    <px:PXLayoutRule runat="server" ID="CstPXLayoutRule45" StartGroup="True" GroupCaption="Customer"></px:PXLayoutRule>
                    <px:PXSelector AllowEdit="True" runat="server" ID="CstPXSelector46" DataField="CustomerClassID"></px:PXSelector>
                    <px:PXSelector AllowEdit="True" runat="server" ID="CstPXSelector47" DataField="CustomerNumberingID"></px:PXSelector>
                    <px:PXSegmentMask AllowEdit="" runat="server" ID="CstPXSegmentMask48" DataField="CustomerTemplate"></px:PXSegmentMask>
                    <px:PXSegmentMask AllowEdit="True" runat="server" ID="CstPXSegmentMask49" DataField="GuestCustomerID"></px:PXSegmentMask>
                    <px:PXSegmentMask runat="server" ID="CstPXSegmentMask50" DataField="InventoryTemplate"></px:PXSegmentMask>
                </Template>
                <ContentLayout ControlSize="XM"></ContentLayout>
                <ContentLayout LabelsWidth="M"></ContentLayout>
            </px:PXTabItem>
            <px:PXTabItem Text="Inventory Settings">
                <Template>
                    <px:PXLayoutRule ControlSize="L" LabelsWidth="M" runat="server" ID="CstPXLayoutRule56" StartGroup="True" GroupCaption="Inventory Settings"></px:PXLayoutRule>
                    <px:PXSelector AllowEdit="True" CommitChanges="True" runat="server" ID="CstPXSelector10" DataField="StockItemClassID"></px:PXSelector>
                    <px:PXSelector AllowEdit="True" CommitChanges="True" runat="server" ID="CstPXSelector9" DataField="NonStockItemClassID"></px:PXSelector>
                    <px:PXDropDown runat="server" ID="CstPXDropDown68" DataField="StockSalesCategoriesIDs"></px:PXDropDown>
                    <px:PXDropDown runat="server" ID="CstPXDropDown67" DataField="NonStockSalesCategoriesIDs"></px:PXDropDown>
                    <px:PXDropDown CommitChanges="True" runat="server" ID="edVisibility" DataField="Visibility"></px:PXDropDown>
                    <px:PXDropDown CommitChanges="True" runat="server" ID="CstPXDropDown57" DataField="Availability"></px:PXDropDown>
                    <px:PXDropDown CommitChanges="True" runat="server" ID="CstPXDropDown58" DataField="NotAvailMode"></px:PXDropDown>
                    <px:PXDropDown CommitChanges="True" runat="server" DataField="AvailabilityCalcRule" ID="CstPXDropDown45"></px:PXDropDown>
                    <px:PXDropDown CommitChanges="True" runat="server" ID="CstPXDropDown71" DataField="WarehouseMode"></px:PXDropDown>
                </Template>
            </px:PXTabItem>
            <px:PXTabItem Text="Order Settings">
                <Template>
                    <px:PXLayoutRule LabelsWidth="SM" ControlSize="M" runat="server" ID="CstPXLayoutRule112" StartColumn="True"></px:PXLayoutRule>
                    <px:PXLayoutRule LabelsWidth="SM" ControlSize="M" runat="server" ID="CstPXLayoutRule115" StartGroup="True" GroupCaption="General"></px:PXLayoutRule>
                    <px:PXFormView RenderStyle="Simple" DataMember="CurrentBinding" runat="server" ID="frmCurrentBinding1">
                        <Template>
                            <px:PXLayoutRule StartColumn="True" LabelsWidth="SM" ControlSize="M" runat="server" ID="PXLayoutRule1" StartRow="True"></px:PXLayoutRule>
                            <px:PXSegmentMask runat="server" ID="edBranchID" DataField="BranchID" AllowEdit="True"></px:PXSegmentMask>
                        </Template>
                    </px:PXFormView>
                    <px:PXLayoutRule LabelsWidth="SM" ControlSize="M" GroupCaption="Order" runat="server" ID="CstPXLayoutRule75" StartGroup="True"></px:PXLayoutRule>
                    <px:PXSelector CommitChanges="True" AllowEdit="True" runat="server" ID="edOrderTpe" DataField="OrderType"></px:PXSelector>
                    <px:PXSelector CommitChanges="True" AllowEdit="True" runat="server" ID="edReturnOrderType" DataField="ReturnOrderType"></px:PXSelector>
                    <px:PXSelector AllowEdit="True" runat="server" ID="edRefundItem" DataField="RefundAmountItemID"></px:PXSelector>
                    <px:PXSelector AllowEdit="True" runat="server" ID="edReasonCode" DataField="ReasonCode"></px:PXSelector>
	<px:PXNumberEdit runat="server" ID="CstPXNumberEdit94" DataField="MaxRefundDays" />
                    <px:PXDropDown ID="edTimeZone" runat="server" DataField="OrderTimeZone"></px:PXDropDown>
                    <px:PXDropDown runat="server" ID="CstPXDropDown80" DataField="PostDiscounts" CommitChanges="True"></px:PXDropDown>
                    <px:PXLayoutRule LabelsWidth="SM" ControlSize="M" runat="server" ID="CstPXLayoutRule117" StartGroup="True" GroupCaption="Taxes"></px:PXLayoutRule>
                    <px:PXCheckBox runat="server" ID="CstPXCheckBox2" DataField="TaxSynchronization" CommitChanges="True"></px:PXCheckBox>
                    <px:PXSelector AutoRefresh="True" runat="server" ID="CstPXSelector118" DataField="DefaultTaxZoneID" CommitChanges="True"></px:PXSelector>
                    <px:PXCheckBox runat="server" ID="CstPXCheckBox1" DataField="UseAsPrimaryTaxZone"></px:PXCheckBox>
                    <px:PXLayoutRule LabelsWidth="SM" ControlSize="M" runat="server" ID="PXLayoutRule118" StartGroup="True" GroupCaption="Substitution Lists"></px:PXLayoutRule>
                    <px:PXSelector CommitChanges="True" AllowEdit="False" runat="server" ID="PXSelector2" DataField="TaxSubstitutionListID"></px:PXSelector>
                    <px:PXSelector CommitChanges="True" AllowEdit="False" runat="server" ID="PXSelector3" DataField="TaxCategorySubstitutionListID"></px:PXSelector>
                    <px:PXLayoutRule ControlSize="L" LabelsWidth="M" runat="server" ID="CstPXLayoutRule85" StartColumn="True"></px:PXLayoutRule>
                    <px:PXLayoutRule GroupCaption="Shipping Option Mapping" runat="server" ID="CstPXLayoutRule76" StartGroup="True"></px:PXLayoutRule>
                    <px:PXGrid Height="200px" Width="660px" SyncPosition="True" AllowPaging="False" SkinID="Inquire" AutoAdjustColumns="True" MatrixMode="True" runat="server" ID="ShippingMappings">
                        <Levels>
                            <px:PXGridLevel DataMember="ShippingMappings">
                                <Columns>
                                    <px:PXGridColumn CommitChanges="True" TextAlign="Center" Type="CheckBox" DataField="Active" Width="80"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="ShippingMethod" Width="120"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="CarrierID" Width="120"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="ZoneID" Width="100"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="ShipTermsID" Width="100"></px:PXGridColumn>
                                </Columns>
                            </px:PXGridLevel>
                        </Levels>
                        <ActionBar>
                            <Actions>
                                <AddNew Enabled="True"></AddNew>
                            </Actions>
                        </ActionBar>
                        <ActionBar>
                            <Actions>
                                <Delete Enabled="True"></Delete>
                            </Actions>
                        </ActionBar>

                    </px:PXGrid></Template>
            </px:PXTabItem>
            <px:PXTabItem Text="Payment Settings">
                <Template>
                    <px:PXLayoutRule ControlSize="L" LabelsWidth="M" runat="server" ID="CstPXLayoutRule120" StartColumn="True"></px:PXLayoutRule>
                    <px:PXLayoutRule GroupCaption="Payment Method Mapping" runat="server" ID="CstPXLayoutRule122" StartGroup="True"></px:PXLayoutRule>
                    <px:PXGrid SyncPosition="True" TabIndex="30400" Height="160px" runat="server" ID="PaymentsMethods" AllowPaging="False" AutoAdjustColumns="False" Caption="Base Currency Payment Methods" CaptionVisible="True" MatrixMode="True" SkinID="Inquire" Width="100%">
                        <Levels>
                            <px:PXGridLevel DataMember="PaymentMethods">
                                <Columns>
                                    <px:PXGridColumn CommitChanges="True" TextAlign="Center" Type="CheckBox" DataField="Active" Width="80"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="StorePaymentMethod" Width="200"></px:PXGridColumn>
                                    <px:PXGridColumn CommitChanges="True" DataField="PaymentMethodID" Width="140"></px:PXGridColumn>
                                    <px:PXGridColumn CommitChanges="True" DataField="CashAccountID" Width="140"></px:PXGridColumn>
                                    <px:PXGridColumn CommitChanges="True" DataField="ProcessingCenterID" Width="120"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="CuryID" Width="80"></px:PXGridColumn>
                                    <px:PXGridColumn TextAlign="Center" Type="CheckBox" DataField="ProcessRefunds" Width="100"></px:PXGridColumn>
                                    <px:PXGridColumn TextAlign="Center" Type="CheckBox" DataField="ReleasePayments" Width="80"></px:PXGridColumn>
                                </Columns>

                                <RowTemplate>
                                    <px:PXSelector AutoRefresh="True" runat="server" ID="CstPXSelector112" DataField="CashAccountID"></px:PXSelector>
                                </RowTemplate>
                            </px:PXGridLevel>
                        </Levels>
                        <Mode AllowDelete="True" AllowAddNew="True"></Mode>
                        <ActionBar ActionsVisible="True" DefaultAction="">
                            <Actions>
                                <AddNew Enabled="true" ToolBarVisible="Top" MenuVisible="True"></AddNew>
                                <Delete Enabled="true" ToolBarVisible="Top"></Delete>
                            </Actions>
                        </ActionBar>
                        <AutoCallBack Target="gridMultiCurrency" Command="Refresh">
                            <Behavior CommitChanges="False" RepaintControlsIDs="gridMultiCurrency"></Behavior>
                        </AutoCallBack>
                    </px:PXGrid>
                    <px:PXGrid SkinID="Details" runat="server" ID="gridMultiCurrency" AllowPaging="False" AutoAdjustColumns="False" Caption="Multicurrency Cash Accounts" CaptionVisible="True" Height="100px" Width="450px">
                        <Levels>
                            <px:PXGridLevel DataMember="MultiCurrency">
                                <Columns>
                                    <px:PXGridColumn CommitChanges="True" DataField="CashAccountID" Width="140"></px:PXGridColumn>
                                    <px:PXGridColumn DataField="CuryID" Width="140"></px:PXGridColumn>
                                    <px:PXGridColumn CommitChanges="True" DataField="ProcessingCenterID" Width="150" />
                                </Columns>
                                <RowTemplate>
                                    <px:PXTextEdit runat="server" ID="CstPXTextEdit110" DataField="Currency"></px:PXTextEdit>
                                    <px:PXSelector CommitChanges="True" runat="server" ID="CstPXSelector111" DataField="CashAccountID" AutoRefresh="True"></px:PXSelector>
                                    <px:PXSelector CommitChanges="True" runat="server" ID="CstPXSelector117" DataField="ProcessingCenterID" AutoRefresh="True"></px:PXSelector>
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
