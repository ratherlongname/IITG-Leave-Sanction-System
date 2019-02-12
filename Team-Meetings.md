# Team Meetings
A log of all the team meetings held, including meeting attendees and work discussed.

## 30<sup>th</sup> January 2019

### Attendees
* Kapil Jangid
* Lucky Singh
* Vakul Gupta
* Shivam Bansal

### General Overview of Software

#### 1 Login / Registration

##### 1.1 Registration
* User registers by filling their IITG email address and creates a password.
* Basic information is collected on creation of new account. This can be -
    * Name
    * Designation (HoD / Professor / Assistant Professor)
    * Roll No.
    * Programme (M. Tech / PhD)
    * Department
    * TA Supervisor / Guide
* At this point this user is verified by the admin, and their details are added to the database.

##### 1.2 Login
* Student / Faculty log into the system by providing their IITG email address and password.
* This is authenticated against a database of all registered users.

#### 2 After Login

##### 2.1 Students

###### 2.1.1 Submit Leave
* Apply for leave under various categories -
    * Ordinary
    * Medical
    * Academic

###### 2.1.2 Cancel Leave
* Cancel leave that was previously applied for, but is no longer needed by student.

###### 2.1.3 Leave Record
* View complete leave record, showing -
    * Status of pending leaves
    * Record of approved / rejected leaves

###### 2.1.4 Notifications
* View notifications of new activity in applied leaves -
    * Rejection / approval of applied leave
    * Remark added to leave application by faculty

##### 2.2 Faculty

###### 2.2.1 Approve leave
* Approve / reject or forward a student's leave
* Check leave balance of student applying for leave

###### 2.2.2 Notifications
* View notifications of new activity -
    * New leave application by student
    * Cancellation of leave by student
    * Rejection / approval of leave by higher authority
    * Remark added to leave application by higher authority
    
    
## 2<sup>nd</sup> February 2019

### Attendees
* Kapil Jangid
* Lucky Singh
* Vakul Gupta
* Shivam Bansal

### Database Structures, GUI components and Database Inter-Linking

#### 1 Basic Overview
##### 1.1 Deciding the number, names of databases

##### 1.2 Deciding the number of columns in each database
* 1.2.1 Checking common columns and deciding basic implementation of data types.
      
#### 2 Deciding the interlink between each type of database
* 2.1 Completely Finalsing the control flow of Software.
* 2.2 Finalising the rough work distrubution in each database.
* 2.3 Decided working of timings and place.
#### 3 Finalising the GUI basic components and Keeping up scope for adding some components if necessary.
##### 3.1 Elaborated discussion on working of each form and its components.
###### 3.1.1  Login/SignUp page
* It provides the option for user to Login if it is a existing user ,else register for a new user .
* Login  
   *  It takes username and password and validate against a present database.
* SignUp
   * It prompts the user to register as a new user.
   * It takes the necessary information and enter into an appropriate datbase.
           
###### 3.1.2 Profile Page
* It provides the user and option to apply for new leave, view old leaves,view notification, and view incmoing list(only         for professors)
* It displays the basic info on the same page.
* It contains an panel which by default shows the old leaves.
* When other option is selected , a new information is diplayed in panel.

## 04<sup>nd</sup> February 2019

### Attendees
* Kapil Jangid
* Lucky Singh
* Vakul Gupta
* Shivam Bansal
* Hansraj Patel
* Tikaram Meena

#### 1 New Features Added
##### 1.1 Captcha
* Captcha was added to distinguish human from machine input.
* Added from internet.

##### 1.2 Notifications
* To display notifications we decided to add a new column type.It holds only three values.

##### 1.3 Edit Profile
* If user wants to edit his/her profile. He/She can edit using this button.

#### 2 New Suggestions
##### 2.1 Database Table for Admin
* Database table for Admin was one of the suggestions.
* Later the idea was dropped because we gave database exception to a perticular user who will be called as superuser.Which means superuser is a user with exception in database.

##### 2.2 Tabs
* Use different tabs instead of different forms to reduce number of forms.

#### 3 Tasks Completed
##### 3.1 Form1
* Finalised Form1 which is login form1(By Lucky Singh).

##### 3.2 GUI of Form1 & Form2
* GUI of Form1 & Form2 almost completed(By Hansraj Patel and Kapil Jangid).

#### 4 Tasks in Running

##### 4.1 Form2
* Vakul Gupta and Shivam were handling backhand of Form2.

##### 4.2 Form3
* Form3 rough design and buttons created(By Lucky and Kapil).

## 07<sup>nd</sup> February 2019

### Attendees
* Kapil Jangid
* Lucky Singh
* Vakul Gupta
* Shivam Bansal
* Hansraj Patel
* Tikaram Meena

#### 1 New Features Added
##### 1.1 Update Button in Form2
* To update new entered data in database table.

##### 1.2 View Profile
* If any user wants to see is profile.All basic information of user will be displayed here.
* Basic information of that user will be shown in Form4.

##### 1.3 Form4
* Form4 was added to display a user's  profile.

#### 2 Task Completed
##### 2.1 Form4
* Backhand (By Vakul and Lucky)
* GUI of Form4 completed(By Hansraj).

##### 2.2 Form2
* Backhand (By Vakul).

#### 3 Tasks in Running
##### 3.1 Form3
* Backhand (By Shivam and Tikaram).

##### 3.2 Form5
* Backhand (By Lucky).

## 11<sup>nd</sup> February 2019

### Attendees
* Kapil Jangid
* Lucky Singh
* Vakul Gupta
* Shivam Bansal
* Hansraj Patel
* Tikaram Meena

#### 1 Task Completed
##### 1.1  User Documentation
* Final User Documentation (By Tikaram Meena).

##### 1.2 Technical Documentation
* Final Technical Documentation (By Kapil and Lucky).

##### 1.3 Finalisation
* Merging and finalsing Design and code(All Members).

##### 1.4 GUI of all forms
* Finalised(By Hansraj).

#### 2 Debug
* tried corner cases.
