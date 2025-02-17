## Automate Readme


###### Description
This is a project that inject financial data into cloud-based management software Buildertrend.

###### Dependency
In order to run Automate,  you need Selenium, Tesseract, GemBox.PDF as dependency libraries.
###### Setup Environment
Go to Command Prompt.
Go to the  following directory and type command:

```
C:\Program Files (x86)\Google\Chrome\Application>chrome.exe --remote-debugging-port=9999 --user-data-dir=C:\Users\lisa\OneDrive\Documents\Chrome_Test
```
This command build a Chrome Driver directory displays besides Automate project. Only local connections are allowed.
Log in in the Buildertrend Chrome and go to Summary page.


###### Instructions
1st: Open the Chrome browers built for Automate, log in in the Buildertrend.
2nd: Open invoice, extract information from it, or type in, add to list.
3nd: Click Start.


###### Debug
If webpage no respond at the start
----Reopen the spcific Chrome browers built for Automate.
If Automate stop during injections, the process is interuped by error.
----Reopen Automate and resume.

