# HTTPDebuggerPro KeyGen
A KeyGen for HTTPDebuggerPro written in C#.
They do not even protect their executables, so.. anyone could do this, but got it as a little KeyGen challenge :P

## Original Key Check
The following function sub_421C50 uses the renamed function keyCheck, which checks if the key is 16 bytes long and if the 4th byte is 7C. Yes, we could patch that address and will work just fine with any key.

![alt text](https://i.imgur.com/pOyddQ7.png)

## Original Key Generator

4th byte will be always 7C. Ex: XXXXXX7CXXXXXXXX 16long

![alt text](https://i.imgur.com/6YvdXxZ.png)

## Original Serial Number Generator

The function sub_421F30 does generate the Serial Number (SN) from HTTPDebuggerPro version + disk serial number.
Ex: SNXXXXXXXXXX SN+10long

![alt text](https://i.imgur.com/90wd2Eg.png)

# Instructions:
- Open HTTPDebuggerPro at least one time.
- Generate a key with the KeyGen.
- Press Apply button.

^^^ if does not work, do it without internet access.

# Install renamed files:
- Put them in the HTTPDebuggerPro installation directory.
- Install the service with the following command:
```
  cmd sc create xcHTTP binpath="C:\Program Files (x86)\HTTPDebuggerPro\xc.exe" type=own start=auto displayname=xc
```
- Open xcUI :P
