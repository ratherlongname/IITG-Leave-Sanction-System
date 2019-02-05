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
    
    
## 2<sup>th</sup> February 2019

### Attendees
* Kapil Jangid
* Lucky Singh
* Vakul Gupta
* Shivam Bansal

### Database Structures,GUI components and Database Inter-Linking

#### 1 Basic Overview
##### 1.1 Deciding the number,names of databases

##### 1.2 Deciding the number of columns in each database
      ##### 1.2.1 Checking common columns and deciding basic implementation of data types.
      
#### 2 Deciding the interlink between each type of database
      * 2.1 Completely Finalsing the control flow of Software.
      * 2.2 Finalising the rough work distrubution in each database.
      * 2.3 Decided working of timings and place.
#### 3 Finalising the GUI basic components and Keeping up scope for adding some components if necessary.
    ##### 3.1 Elaborated discussion on working of each form and its components.
    ###### 3.1.1  Login/SignUp page
          * It provides the option for user to Login if it is a existing user ,else register for a new user .
          * Login  
            **  It takes username and password and validate against a present database.
          * SignUp
            ** It prompts the user to register as a new user.
            ** It takes the necessary information and enter into an appropriate datbase.
           
   ###### 3.1.2 Profile Page
         * It provides the user and option to apply for new leave, view old leaves,view notification, and view incmoing list(only
         for professors)
         * It displays the basic info on the same page.
         * It contains an panel which by default shows the old leaves.
         * When other option is selected , a new information is diplayed in panel.
         
            
               
    
