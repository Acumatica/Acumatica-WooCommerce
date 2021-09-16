# Acumatica WooCommerce Connector


## Supported Entities

<table>
	<tr>
		<td colspan="2"> <b>Acumatica</b> </td> 
  	<tr>
    		<td><b>Import Entities</b></td>
		<td><b>Export Entities</b></td>
	<tr>
		<td> <a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Specifications/Customer.md">Customers</a></td>
		<td> <a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Specifications/Stock%20Items.md">Stock items</a></td>
	<tr>
    	<tr>
		<td><a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Specifications/Sales%20Order.md">Sales orders </a></td>
		<td><a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Specifications/Sales%20Category.md">Sales categories</a></td>
	<tr>
    	<tr>
		<td><a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Specifications/Payments.md">Payment details</a></td>
		<td><a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Mappings/Shipments%20Export.md">Shipment details</a> </td>
</table>

## Prerequisites | Supported Versions

Acumatica 2021 R1 update 4.  

Wordpress Version 5.7.2 with WooCommerce Version 5.3.0 plugin. 

WooCommerce Authorize.Net Gateway [plugin](https://woocommerce.com/products/authorize-net/?quid=a4ec6634f577691121a02dde630ad4c8) requires to configure in order to handle the Authorize.Net Credit Card payments.

WooCommerce API [Extension library](https://github.com/Acumatica/Acumatica-WooCommerce/tree/2021R104/WooCommerceAPIExt).

WooCommerce [AvaTaxV 1.11.2](https://woocommerce.com/products/woocommerce-avatax/?quid=e9ffd5af069c8fc58e1b263ad6765b69).

## Quick Start

### Installation

Install customization deployment package from [here](https://github.com/Acumatica/Acumatica-WooCommerce/tree/2021R104).


### Usage

#### Connection Settings
Go to main menu, open Commerce menu item, and click on WooCommerce Stores and WooCommerce Stores workspace will open.

![Screenshot](/Documentation/Images/Commenuitem.png)

![Screenshot](/Documentation/Images/Wooworkspace.png)

1.	Connector should be shown as WooCommerce.

2.	Enter your WooCommerce store name.

*To continue with steps 3-6 need to Log in to WooCommerce admin portal,*

3.	Copy and paste the WooCommerce admin URL.

4.	Copy and paste the Request URL until the version string from the admin portal.

	(E.g: http(s)://your-wordpress-host/wp-json/v3 ^^)

5.	Copy and paste the Consumer Key from the admin portal.

6.	Copy and paste the Consumer secret from the admin portal.

7.	Test the connection.

*^^ Wordpress hosted URL.*

#### Entity Settings

Under Entity Settings page, click on Active check box to activate necessary entities for the synchronization and click on Save.

![Screenshot](/Documentation/Images/EntitySet.png)

### Entity Synchronization (Import/ Export)

#### Customer Settings

![Screenshot](/Documentation/Images/CusSet.png)

Before syncing customers from WooCommerce to Acumatica above mentioned Customer configuration settings need to be completed. 

1.	Need to mention the customer class that is assigned to new customers imported to Acumatica from the WooCommerce store and thus used to provide their default settings.

2.	Need to mention the numbering sequences to be used for generating identifiers for imported customers.

3.	Need to mention the generic customer account that appears on imported sales orders that were placed in the WooCommerce store as guest orders. This customer account is not exported to the WooCommerce store during the synchronization of customers.

4.	Need to mention if the company uses segmented keys that consist of multiple segments for customers, it is necessary to also specify the numbering templates in the Customer Numbering Template box and indicate which of the key segments should be auto numbered.

#### Inventory Settings

![Screenshot](/Documentation/Images/InventorySettings.png)

Before syncing Stock Items to WooCommerce from Acumatica above mentioned Inventory configuration settings need to be completed. 

1.	Need to mention the default Stock Categories when exporting Stock items, (list of item sales categories) and that value(s) will be picked as the default value(s) of product category when creating a product in WooCommerce.

2.	Need to mention the default visibility of the WooCommerce product and that value will be used as the visibility of the product when creating a product in WooCommerce.

3.	Need to mention the default Availability and that value will be used to decide the Availability of the product when creating a product in WooCommerce.

4.	Need to mention When Qty Unavailable and that value will be used to decide when there is no inventory available when syncing the availability entity.

#### Order Settings

![Screenshot](/Documentation/Images/OrderSettings.png)

Before syncing Sales Orders from WooCommerce to Acumatica above mentioned Order configuration settings need to be completed.

1.	Need to mention the branch that is inserted in the sales orders and payments imported to Acumatica from the WooCommerce store.

2.	The order type in Acumatica that is assigned to imported sales orders to indicate that the orders have originated in the WooCommerce store.

3.	The time zone the system will use for each sales order imported from the WooCommerce store when it is created in Acumatica. The order time zone is needed to determine the correct date and time of the order if Acumatica and the WooCommerce store are in different time zones.

4.	The level on which discounts appear in each sales order imported from WooCommerce. {For document discounts to be imported correctly, the Customer Discounts feature must be enabled on the Enable/Disable Features (CS100000)}

5.	A check box that indicates (if selected) that taxes should be synchronized between Acumatica and the WooCommerce store during the import of sales orders. If the checkbox is not selected Tax is not synchronized to Acumatica.

6.	The identifier of the tax zone that is assigned by default to each sales order imported to Acumatica from the WooCommerce store if no other tax zone has been identified during the import of the order. The box is available if the Tax Synchronization check box is selected.

7.	A check box that selects to indicate that the tax zone selected in Default Tax Zone should be assigned to each sales order imported to Acumatica from the WooCommerce store, regardless of whether any other tax zone has been identified during the import of the order. This box is available if the Default Tax Zone is specified.

8.	The substitution list to be used for mapping tax IDs between Acumatica and the WooCommerce store. During the import of each sales order, if the system cannot find the tax ID specified in the order, it checks if there is a mapped tax ID in the substitution list specified in this box. Substitution lists are defined on the Substitution Lists (SM206026).

9.	The substitution list to be used for mapping tax categories Acumatica with tax classes in the WooCommerce store. During the import of a sales order, if the system cannot find the tax category specified in the order, it checks if there is a mapped tax category in the substitution list specified in this box. Substitution lists are defined on the Substitution Lists (SM206026).

10.	Shipping options is to define the mapping of each shipping option (which is a combination of a shipping zone and shipping method) defined in WooCommerce to the ship via code, and optionally, shipping zone and shipping terms defined in Acumatica.

#### Payment Settings

![Screenshot](/Documentation/Images/PaymentSettings.png)

Before syncing Payment details from WooCommerce to Acumatica above mentioned payment configuration settings need to be completed. 

1.	A check box that indicates (if selected) that payment processing is enabled for the payment method. If this check box is cleared for a payment method, when an order is placed in the WooCommerce store and this payment method is selected at checkout, the corresponding payment is not imported from the WooCommerce store to Acumatica. This check box is cleared by default.

2.	The payment method defined in the WooCommerce store. This column is populated automatically. However, user can manually add additional mappings of payment options, if necessary. 

3.	The identifier of the payment method in Acumatica that corresponds to the store payment method.

4.	The cash account associated with the payment method in Acumatica. Only cash accounts in the base currency can be selected.

5.	The processing center configured in Acumatica for the card-based payment method selected in the Payment Method ID column and the cash account in the base currency selected in the Cash Account column.

6.	The identifier of the currency of the cash account.

7.	A check box that selects to indicate that payments should be automatically released as soon as they are imported to Acumatica. If this check box is selected for a card-based payment method associated with a credit card processing center in Acumatica (that is, for the payment method for which a processing center is selected in the Proc. Center ID column), only payments that have been captured in the store will be automatically released on import.

8.	This is to select additional cash accounts for transactions in currencies other than the base currency. For each non-base currency used in store transactions, the user should specify an additional cash account.

### Prepare Data 

Once the initial entity settings have been completed go to Commerce menu item and click on Prepare Data and Prepare Data workspace will open.

![Screenshot](/Documentation/Images/PrepareData.png)

![Screenshot](/Documentation/Images/PrepareData2.png)

Select the necessary entity that want to sync in the Entity dropdown and then click on selected check box in the working area. Or keep the Entity dropdown blank and select the required entities by clicking on selected check box.

Then after click on Prepare to prepare the data that can be synchronized. 

![Screenshot](/Documentation/Images/PrepareData3.png)

### Process Data  

Once preparing Data have been completed, go to Commerce menu item, and click on Process Data and Process Data workspace will open.

![Screenshot](/Documentation/Images/ProcessData.png)

![Screenshot](/Documentation/Images/ProcessData2.png)

Select the required Entity and then select the required transaction(s) that need to sync by selecting the check box(s). Then click on Process. Or click on Process All to process all the prepared transaction related to the selected Entity.

![Screenshot](/Documentation/Images/ProcessData3.png)

## Quality Assurance

Please refer the following locations for Test Materials. The functional Test cases and the Automated test cases are included there.
You may refer the README file in case if you require to setup the WooCommerce Test Project for SDK.

•  	[Functional Test Cases](/Test%20Cases/Functional%20Test%20Cases)

• 	[WooCommerce Automation Test Project for SDK](https://github.com/Acumatica/Acumatica-WooCommerce/tree/2021R104/Tests/ACWC)

## Notes

•	There is no configuration setting to be done for Sales Category entity and Shipment entity. Once the entity is activated in Entity setting, those entities will be available to prepare and process data. 

•	After all initial configurations are done, before syncing stock items in the first time, **sales category synchronization must be completed** otherwise system will not update relevant sales category as a product category in WooCommerce store. 

## Known Issues

•	WooCommerce sales orders with Refunds are not handled in this customization package, it will be handled in the M2 release. The synchronization for orders of refunds statuses will be filtered. 

•	Synchronization of Non-Stock Items and Template Items will be handled in the M2 release. The errors might be occurred in case if it tries to synchronize Non-Stock Items and Template items. 

•	Synchronization of product availability will be handled in the M2 release.

•	Synchronization of WooCommerce Grouped Products and External/Affiliate Products are not handled in this customization package.

•	For Import/ Export filtering and mapping is not supported in this customization package. It will be available in an upcoming release.

## Copyright and License

Copyright © `2021` `Acumatica, INC`

This component is licensed under the MIT License, a copy of which is available online [here](LICENSE).
