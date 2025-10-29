# speed-typing-test
## Features

- Generates random paragraphs using the **Bogus** library (`Lorem` dataset)  
- Measures total typing duration using `Stopwatch`  
- Calculates character-by-character **accuracy**  
- Displays **WPM** and performance statistics  
- Lightweight and entirely console-based — no setup beyond .NET and Bogus  

---

## How It Works

1. The user specifies how many sentences to generate  
2. The app creates a random paragraph using the Bogus `Lorem` dataset  
3. The paragraph is displayed in the console  
4. The user retypes it manually  
5. Once typing is complete, the app reports:
   - **Time elapsed**
   - **Accuracy (%)**
   - **Words per minute (WPM)**

---

## Tech Stack

| Component | Description |
|------------|-------------|
| **Language** | C# |
| **Framework** | .NET |
| **Library** | [Bogus](https://github.com/bchavez/Bogus) — for generating placeholder text |

---

## Example Output

How many sentences?
2

Lorem ipsum dolor sit amet, consectetur adipiscing elit...

[User types paragraph]

Time elapsed: 00:00:47.8123456
Accuracy: 96.23%
WPM: 42.8
