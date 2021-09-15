The document is consisted with set of instruction requires to configure and setup the WooCommerce Test Project for SDK (Software Development Kit) before you execute the automation test cases.

Prerequisites
1. Please create some sample data mentioned below.

2. Visual Studio 16.8.6 or a latest version is installed to your machine

3. Acumatica ERP Configuration Wizard v21.109.0018 (Update 9) is installed to your machine

4.  Customization package (V43) is downloaded and ready to add as a customization project

5. TestSDK is downloaded from Acumatica Portal

Steps to Start
Please follow the below steps to setup the Test Project

1. Open your ERP Web instance

2.  Create some sample data mentioned below in your application instance

3. Open the downloaded TestSDK related to the v21 update 04 (Ex. TestSDK_21_104_0018) and place the packages folder inside the TestSDK folder

      Tests > Packages

Note: Change the package naming in order to map with SDK version. Ex. Execution.21.102.69.70.nupkg 

4. Change the values for following parameters based on the file configured ERP instance

   <url>URL path for the Web instance</url>
   <login>admin</login>
   <pswd>123</pswd>

4. Download the Chrome driver and save it within the TestSDK followed by the following location

   TestSDK_21_102_0069_70\Chrome\chrome.exe

5. Change the folder path for above downloaded chrome driver in following parameter of conf.xml file

   <browserbin>Your folder path to the chrome driver\TestSDK_21_102_0069_70\Chrome\chrome.exe</browserbin>

6. Update the browser downloaded folder in following parameter

   <browser_downloads_folder>Your folder path\TestSDK_21_102_0069_70\BrowserDownload</browser_downloads_folder>

7. Update location for the log file in order to check the test results

   <logStorage type="htmlfile" level="DEBUG" output folder="Your folder path\TestSDK_21_102_0069_70\logs" screenshotActive="true" />

8. Change the Test case name based on preferred case to test in following location

      <testing>
      <Check Name="ExportStockItemsToWC"/>
      <Check Name="UpdateStockItems_ExportToSP"/>
      </testing>

9.  Change the folder path for the 'Conf.xml' in Test Project at Visual Studio. 

Right click on the Test Project > Go to the properties > Select Debug tab > Change the path for the xml file followed by the below format

\\run /config "<Your folder path\TestSDK_21_102_0069_70\Conf.xml"

10. Run your test via the Visual Studio
