# Cybersecurity_Awareness_Chatbot
this project is a console based chatbot developed in C#. the chatbot is designed to promote cybersecurity awareness by interacting with users and providing basic guidance on online safety topics such as password protection, phishing, and safe browsing.

## Features
- Voice greeting using WAV audio
- ASCII art logo displayed as header
  - User name input and personalized greeting
- Basic chatbot responses (password, phishing, browsing)
  - Input validation for invalid or empty input
- Colored console interface for better user experience

 ### File Overview
 # Program.cs

The entry point of the application.
Responsible for:

Starting the program
Playing the welcome audio
Creating an instance of the chatbot
Launching the chat session
# AudioPlayer.cs

Utility class for handling audio playback.
Responsible for:

Loading embedded audio resources
Playing the welcome greeting sound
Handling audio errors safely

Used by Program.cs at startup.

#  imageDisplay.cs

Displays ASCII images or console graphics during startup.

# ChatBot.cs

Core chatbot logic.
Handles:

User input
Typing animation for bot responses
Chatbot ASCII logo
Cybersecurity explanations
exit keyword to leave the program
Help menu
Keyword-based response detection

This is where most chatbot behavior is implemented.

### Installation & Running
Step 1 — Clone the Repository
git clone https://github.com/ramaaru/Cybersecurity-Awareness-Chatbot.git
Step 2 — Open Project

Open the folder in Visual Studio or VS Code with C# extension.

Step 3 — Ensure Resource Audio Exists

Make sure that welcome.wav is added to:

Properties → Resources.resx

Set:

Build Action: Embedded Resource
Type: Audio
Step 4 — Run the Program

### Author

RAMARU RILISE
