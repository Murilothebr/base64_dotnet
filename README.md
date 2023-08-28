# base64_dotnet
### base64 encoder / decoder for windowns

# How to Setup and use — I will not dispose the .exe directly, so DIY

#### 1. Clone my project: https://github.com/Murilothebr/base64_dotnet

#### 2. Build the project with: dotnet build

#### 3. Enter in the bin folder

#### 3. Copy those files to some other trusted folder, like your script’s folder.

#### 4. Add the environment varible to use this in anywhere with, like:
#### — — setx PATH “%PATH%;C:/your/folder"

#### 5. Try it running “base64 -h” in your cmd

# Using the base64 script
### Encode a string:

### Try the following command to get some help

```
base64 -h
```

### Encode a string:
#### Try the following command to encode a string

```
base64 -e your-string
```

### Decode a string:
#### Try the following command to decode a string

```
base64 -d your-base64-string-from-before
```

### Encode a file:
#### Try the following command to encode a file

```
base64 -e -f /your/file/path
```

### Decode a file:
#### Try the following command to decode a file
```
base64 -d -f your-base64-file-from-before /your/decoded/file/path
```
