
<pre>The document is consisted with set of instruction require to configure and setup the WooCommerce Test Project for SDK (Software Development Kit) before you execute the automation test cases.</pre>
<h1>Prerequisites</h1>
<pre>1. Please create some sample data mentioned below.</pre>
<pre>2. Visual Studio 16.8.6 or a latest version is installed to your machine</pre>
<pre>3. Acumatica ERP Configuration Wizard v21.104.0018 (Update 4) is installed to your machine</pre>
<pre>4.&nbsp; Customization package (V43) is downloaded and ready to add as a customization project</pre>
<pre>5. TestSDK is downloaded from Acumatica Portal</pre>
<h1>Steps to Start</h1>
<pre>Please follow the below steps to setup the Test Project</pre>
<pre>1. Open your ERP Web instance</pre>
<pre>2.&nbsp; Create some sample data mentioned below in your application instance</pre>
<pre>3. Open the downloaded TestSDK related to the v21 update 04 (Ex. TestSDK_21_104_0018) and place the packages folder inside the TestSDK folder</pre>
<pre>&nbsp; &nbsp; &nbsp; Tests &gt; Packages</pre>
<pre>Note: Change the package naming in order to map with SDK version. Ex.&nbsp;Execution.21.102.69.70.nupkg&nbsp;</pre>
<pre>4. Change the values for following parameters based on the file configured ERP instance</pre>
<pre>&nbsp; &nbsp;&lt;url&gt;URL path for the Web instance<a>&lt;/url</a>&gt;<br />&nbsp; &nbsp;&lt;login&gt;admin&lt;/login&gt;<br />&nbsp; &nbsp;&lt;pswd&gt;123&lt;/pswd&gt;</pre>
<pre>4. Download the Chrome driver and save it within the TestSDK followed by the following location</pre>
<pre>&nbsp; &nbsp;TestSDK_21_102_0069_70\Chrome\chrome.exe</pre>
<pre>5. Change the folder path for above downloaded chrome driver in following parameter&nbsp;of conf.xml file</pre>
<pre>&nbsp; &nbsp;&lt;browserbin&gt;Your folder path to the chrome driver\TestSDK_21_102_0069_70\Chrome\chrome.exe&lt;/browserbin&gt;</pre>
<pre>6. Update the browser downloaded folder in following parameter</pre>
<pre>&nbsp; &nbsp;&lt;browser_downloads_folder&gt;Your folder path\TestSDK_21_102_0069_70\BrowserDownload&lt;/browser_downloads_folder&gt;</pre>
<pre>7. Update location for the log file in order to check the test results</pre>
<pre>&nbsp; &nbsp;&lt;logStorage type=&quot;htmlfile&quot; level=&quot;DEBUG&quot; output folder=&quot;Your folder path\TestSDK_21_102_0069_70\logs&quot; screenshotActive=&quot;true&quot; /&gt;</pre>
<pre>8. Change the Test case name based on preferred case to test in following location</pre>
<pre>&nbsp; &nbsp; &nbsp; &lt;testing&gt;<br />&nbsp; &nbsp; &nbsp; &lt;Check Name=&quot;ExportStockItemsToWC&quot;/&gt;<br />&nbsp; &nbsp; &nbsp; &lt;Check Name=&quot;UpdateStockItems_ExportToSP&quot;/&gt;<br />&nbsp; &nbsp; &nbsp; &lt;/testing&gt;</pre>
<pre>9.&nbsp; Change the folder path for the 'Conf.xml' in Test Project at Visual Studio.&nbsp;</pre>
<pre>Right click on the Test Project &gt; Go to the properties &gt; Select Debug tab &gt; Change the path for the xml file followed by the below format</pre>
<pre>\\run /config &quot;&lt;Your folder path\TestSDK_21_102_0069_70\Conf.xml&quot;</pre>
<pre>10. Run your test via the Visual Studio</pre>
<pre>&nbsp;</pre>
<pre>P.S.</pre>
<h1>Test Data</h1>
<h3>Stock Items</h3>
<table>
<tbody>
<tr>
<td>
<pre>Product Name</pre></td>
<td>
<pre>SKU</pre></td></tr>
<tr>
<td>
<pre>Computer keyboard</pre></td>
<td>
<pre>KEYBOARD</pre></td></tr>
<tr>
<td>
<pre>Laptop 12\&quot;</pre></td>
<td>
<pre>LAPTOP12</pre></td></tr>
<tr>
<td>
<pre>Laptop 14\&quot;</pre></td>
<td>
<pre>LAPTOP14</pre></td></tr>
<tr>
<td>
<pre>Monitor 26\&quot;</pre></td>
<td>
<pre>MONITOR26</pre></td></tr>
<tr>
<td>
<pre>Computer mouse</pre></td>
<td>
<pre>MOUSE</pre></td></tr>
<tr>
<td>
<pre>SIM card &amp; contract</pre></td>
<td>
<pre>SIMCARD</pre></td></tr>
<tr>
<td>
<pre>Headset</pre></td>
<td>
<pre>HEADSET</pre></td></tr>
<tr>
<td>
<pre>SIM card &amp; contract</pre></td>
<td>
<pre>SIMCARD</pre></td></tr>
<tr>
<td>
<pre>Computer mouse</pre></td>
<td>
<pre>MOUSE</pre></td></tr>
<tr>
<td>
<pre>Acer Laptop Computer</pre></td>
<td>
<pre>AACOMPUT01</pre></td></tr></tbody></table>
<h3>Tax Data</h3>
<table>
<tbody>
<tr>
<td>
<pre>Tax Name/ Code</pre></td>
<td>
<pre>Amount</pre></td></tr>
<tr>
<td>
<pre>US-NY-TAX NY-1</pre></td>
<td>
<pre>10</pre></td></tr></tbody></table>
<h3>Coupon Discount</h3>
<table>
<tbody>
<tr>
<td>
<pre>Coupon Discount Code</pre></td>
<td>
<pre>Amount</pre></td></tr>
<tr>
<td>
<pre>disc_coupon</pre></td>
<td>
<pre>5%</pre></td></tr></tbody></table>
<p>&nbsp;</p>
<p>&nbsp;</p>
