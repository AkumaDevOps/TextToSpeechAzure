# Text-to-Speech Converter

This repository provides a **simple implementation** for transforming text into speech using Azure's **Text-to-Speech service**. The Text-to-Speech service allows you to generate **high-quality, natural-sounding speech** from text input.

## How it Works

The `text_to_speech.py` script in this repository demonstrates how to utilize the Azure Text-to-Speech service. It takes a text input, sends it to the service for processing, and retrieves the corresponding audio output. The script provides a basic example of how to integrate **text-to-speech capabilities** into your own applications or projects.

## Getting Started

To get started with this repository, follow these steps:

1. Clone the repository to your local machine.
2. Install the necessary dependencies by running `pip install -r requirements.txt`.
3. Obtain your Azure Text-to-Speech **subscription key** and **endpoint**. Visit the Azure portal to create a Text-to-Speech resource and retrieve the required credentials.
4. Replace the placeholder values for `subscription_key` and `endpoint` in the `text_to_speech.py` script with your own credentials.
5. Run the script and provide the desired text as input. The script will send the text to the Azure Text-to-Speech service and save the corresponding speech audio file.

## Important Note

Please note that the repository has **removed the actual codes for the Azure region and API** for security reasons. You will need to insert your own valid subscription key and endpoint in order to use the Text-to-Speech service successfully. Be sure to follow the Azure documentation to obtain the necessary credentials for your specific Azure subscription.

## Contribution

Contributions to this repository are welcome! If you find any issues or have ideas for improvements, please submit a pull request or open an issue.

## Contact

If you have any questions or need further assistance, please feel free to reach out to the repository maintainer.

Enjoy transforming text into speech with Azure's Text-to-Speech service!
