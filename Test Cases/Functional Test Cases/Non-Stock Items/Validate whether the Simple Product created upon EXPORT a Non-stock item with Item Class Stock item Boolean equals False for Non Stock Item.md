
<p><span style="color: rgb(51,51,51);"><br /></span></p>
<p><strong><u><span style="color: rgb(51,51,51);">Description</span></u></strong></p>
<p><span style="color: rgb(51,51,51);"><br /></span></p>
<p><span style="color: rgb(51,51,51);">'Simple Product' created upon EXPORT a Non-stock Item and in WooCom Product type = simple product AND Virtual Boolean should =True</span></p>
<p>&nbsp;</p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">Prerequisites</span></u></strong><span style="color: rgb(51,51,51);">&nbsp;</span></p>
<p style="margin-left: 0.0in;"><span style="color: rgb(51,51,51);">1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</span></p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">Detailed Steps to Test</span></u></strong><span style="color: rgb(51,51,51);">&nbsp;</span></p>
<p style="margin-left: 0.0in;">1. Create a Stock item by filling all the mandatory fields<br />2. ItemClass-&gt; Stock item Boolean= False&nbsp;<strong>&lt;pNon-StockItem&gt;</strong>&nbsp;<br />3. Save the record, Prepare and Process<br />4. Open the record in WooCommerce and validate the product type</p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">Expected Results</span></u></strong><span style="color: rgb(51,51,51);">&nbsp;</span></p>
<p style="margin-left: 0.0in;">In WooCom Product type = simple product AND Virtual Boolean should =True</p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">Test Data</span></u></strong></p>
<p>&nbsp;<strong>&lt;pNonStockItem&gt;</strong></p>
