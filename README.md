# CommentEraser

CommentEraser is a command-line utility for removing comments from source code files. It supports multiple programming languages.

## Features

- Remove single-line and multi-line comments from:
  - Python
  - JavaScript
  - C#
  - HTML
  - CSS
  - Combined HTML, JavaScript, and CSS

## Usage

To use CommentEraser, run the following command in your terminal:

```
.\commenteraser.exe "target_file" language
```

### Parameters

- **target_file**: The path to the source code file from which you want to remove comments.
- **language**: The programming language of the target file. Supported languages include:
  - `python`
  - `javascript`
  - `csharp`
  - `html`
  - `css`
  - `html+javascript+css`

### Example Commands

1. To remove comments from a Python file:
   ```
   .\commenteraser.exe "example.py" python
   ```

2. To remove comments from a JavaScript file:
   ```
   .\commenteraser.exe "example.js" javascript
   ```

3. To remove comments from a combined HTML, JavaScript, and CSS file:
   ```
   .\commenteraser.exe "example.html" html+javascript+css
   ```

## Installation

1. Clone the repository:
   ```
   git clone https://github.com/a-generation/CommentEraser.git
   ```

2. Navigate to the project directory:
   ```
   cd CommentEraser
   ```

3. Build the project using your preferred method or IDE.

## Contributing

Contributions are welcome! If you find a bug or want to add features, please create an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.
