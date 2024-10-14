# WhatsApp Automation Bot

## Overview
This project is a Selenium-based automation bot developed in C# to enhance the message forwarding capabilities of WhatsApp Web. The bot addresses the platform's limitation of forwarding messages to only five contacts at a time, allowing users to forward messages to all contacts seamlessly. Additionally, it identifies and reports a bug related to message forwarding that can cause messages to get stuck in the queue.

https://github.com/user-attachments/assets/ac28b945-55aa-4f1c-9593-ffa2db70f1d1

## Features
- Automates the process of forwarding messages on WhatsApp Web.
- Bypasses the limitation of forwarding to only five contacts at a time.
- Detects and handles message forwarding errors, ensuring smooth operation.
- User-friendly implementation with easy setup instructions.

## Prerequisites
Before running the bot, ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) (version XX or later)
- [Selenium WebDriver](https://www.selenium.dev/downloads/)
- [ChromeDriver](https://chromedriver.chromium.org/downloads) (make sure the version matches your Chrome browser version)

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/whatsapp-automation.git
   cd whatsapp-automation
   ```

2. Install necessary dependencies:
   ```bash
   dotnet restore
   ```

## Usage
1. Open WhatsApp Web and log in using your mobile device.
2. Update the `TestMethod1` in `UnitTest1.cs` with your specific message and recipient logic.
3. Run the bot:
   ```bash
   dotnet test
   ```

## Note
- The bot requires the browser to be open and active while running.
- Ensure that you are logged into WhatsApp Web before executing the script.

## Contributing
Contributions are welcome! If you find any bugs or have suggestions for improvements, please open an issue or submit a pull request.

## License
This project is licensed under the MIT License.

## Contact
For any inquiries or feedback, feel free to reach out to me at [muhammadzainshahzad7@gmail.com](mailto:muhammadzainshahzad7@gmail.com).
