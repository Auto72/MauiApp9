Run the App on Windows.

Navigate to MauiPage1 by clicking the Button on the first page.
Navigate back.
Navigate again to MauiPage1 by clicking the Button on the first page.
Click the Clear button.

You get the error:

Exception thrown: 'System.NullReferenceException' in Microsoft.Maui.Controls.dll
Object reference not set to an instance of an object.

If you go over the variable, you can see it is not null.
The try/catch block doesn't catch this error.

![2](https://github.com/user-attachments/assets/220b13a1-c868-48d7-aa2a-03938127ea1b)
