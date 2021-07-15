
<p>The document is consisted with set of instruction requires to configure and setup the WooCommerce Test Project for SDK (Software Development Kit) before you execute the automation test cases.</p>
<h1>Prerequisites</h1>
<p>1. Please create some sample data mentioned below.</p>
<p>2. Visual Studio 16.8.6 or a latest version is installed to your machine</p>
<p>3. Acumatica ERP Configuration Wizard v21.104.0018 (Update 4) is installed to your machine</p>
<p>4.&nbsp; Customization package (V43) is downloaded and ready to add as a customization project</p>
<p>5. TestSDK is downloaded from Acumatica Portal</p>
<h1>Steps to Start</h1>
<p>Please follow the below steps to setup the Test Project</p>
<p>1. Open your ERP Web instance</p>
<p>2.&nbsp; Create some sample data mentioned below in your application instance</p>
<p>3. Open the downloaded TestSDK related to the v21 update 04 (Ex. TestSDK_21_104_0018) and place the packages folder inside the TestSDK folder</p>
<p>&nbsp; &nbsp; &nbsp; Tests &gt; Packages</p>
<p>Note: Change the package naming in order to map with SDK version. Ex.&nbsp;Execution.21.102.69.70.nupkg&nbsp;</p>
<p>4. Change the values for following parameters based on the file configured ERP instance</p>
<p>&nbsp; &nbsp;&lt;url&gt;URL path for the Web instance<a>&lt;/url</a>&gt;<br />&nbsp; &nbsp;&lt;login&gt;admin&lt;/login&gt;<br />&nbsp; &nbsp;&lt;pswd&gt;123&lt;/pswd&gt;</p>
<p>4. Download the Chrome driver and save it within the TestSDK followed by the following location</p>
<p>&nbsp; &nbsp;TestSDK_21_102_0069_70\Chrome\chrome.exe</p>
<p>5. Change the folder path for above downloaded chrome driver in following parameter&nbsp;of conf.xml file</p>
<p>&nbsp; &nbsp;&lt;browserbin&gt;Your folder path to the chrome driver\TestSDK_21_102_0069_70\Chrome\chrome.exe&lt;/browserbin&gt;</p>
<p>6. Update the browser downloaded folder in following parameter</p>
<p>&nbsp; &nbsp;&lt;browser_downloads_folder&gt;Your folder path\TestSDK_21_102_0069_70\BrowserDownload&lt;/browser_downloads_folder&gt;</p>
<p>7. Update location for the log file in order to check the test results</p>
<p>&nbsp; &nbsp;&lt;logStorage type=&quot;htmlfile&quot; level=&quot;DEBUG&quot; output folder=&quot;Your folder path\TestSDK_21_102_0069_70\logs&quot; screenshotActive=&quot;true&quot; /&gt;</p>
<p>8. Change the Test case name based on preferred case to test in following location</p>
<p>&nbsp; &nbsp; &nbsp; &lt;testing&gt;<br />&nbsp; &nbsp; &nbsp; &lt;Check Name=&quot;ExportStockItemsToWC&quot;/&gt;<br />&nbsp; &nbsp; &nbsp; &lt;Check Name=&quot;UpdateStockItems_ExportToSP&quot;/&gt;<br />&nbsp; &nbsp; &nbsp; &lt;/testing&gt;</p>
<p>9.&nbsp; Change the folder path for the 'Conf.xml' in Test Project at Visual Studio.&nbsp;</p>
<p>Right click on the Test Project &gt; Go to the properties &gt; Select Debug tab &gt; Change the path for the xml file followed by the below format</p>
<p>\\run /config &quot;&lt;Your folder path\TestSDK_21_102_0069_70\Conf.xml&quot;</p>
<p>10. Run your test via the Visual Studio</p>

<h3>P.S.</h3>
<h1>Test Data</h1>
<h3>Stock Items</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Product Name</strong></p></td>
<td>
<p><strong>SKU</strong></p></td></tr>
<tr>
<td>
<p>Computer keyboard</p></td>
<td>
<p>KEYBOARD</p></td></tr>
<tr>
<td>
<p>Laptop 12\&quot;</p></td>
<td>
<p>LAPTOP12</p></td></tr>
<tr>
<td>
<p>Laptop 14\&quot;</p></td>
<td>
<p>LAPTOP14</p></td></tr>
<tr>
<td>
<p>Monitor 26\&quot;</p></td>
<td>
<p>MONITOR26</p></td></tr>
<tr>
<td>
<p>Computer mouse</p></td>
<td>
<p>MOUSE</p></td></tr>
<tr>
<td>
<p>SIM card &amp; contract</p></td>
<td>
<p>SIMCARD</p></td></tr>
<tr>
<td>
<p>Headset</p></td>
<td>
<p>HEADSET</p></td></tr>
<tr>
<td>
<p>SIM card &amp; contract</p></td>
<td>
<p>SIMCARD</p></td></tr>
<tr>
<td>
<p>Computer mouse</p></td>
<td>
<p>MOUSE</p></td></tr>
<tr>
<td>
<p>Acer Laptop Computer</p></td>
<td>
<p>AACOMPUT01</p></td></tr></tbody></table>
<p>&nbsp;</p>
<h3>Tax Data</h3>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td>
<p><strong>Tax Name/ Code</strong></p></td>
<td>
<p><strong>Amount</strong></p></td></tr>
<tr>
<td>
<p>US-NY-TAX NY-1</p></td>
<td>
<p>10</p></td></tr></tbody></table>
<p>&nbsp;</p>
<h3>Coupon Discount</h3>
<table>
<tbody>
<tr>
<td>
<p><strong>Coupon Discount Code</strong></p></td>
<td>
<p><strong>Amount</strong></p></td></tr>
<tr>
<td>
<p>disc_coupon</p></td>
<td>
<p>5%</p></td></tr></tbody></table>
<p>&nbsp;</p>
<p>&nbsp;</p>
