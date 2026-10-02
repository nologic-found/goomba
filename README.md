# Goomba Console Animation

A simple C# console animation project that renders ASCII-art Goombas moving across the terminal.  
It demonstrates basic object-oriented design using an interface, multiple character implementations, and a lightweight animation loop.

## Features

- ASCII art character animation in the console
- Multiple character types:
  - `Goomba`
  - `ParaGoomba`
  - `GoombaAdv`
- Shared character contract through the `Character` interface
- Movement and direction switching
- Frame toggling for a simple walking animation

## How it works

The project uses:

- `Character` — an interface that defines:
  - `Move()`
  - `ChangeDirection()`
  - `DrawSprites()`

- `Goomba`, `ParaGoomba`, and `GoombaAdv` that implements `Character`

- `GoombaAni` — an animation controller that:
  - clears the console
  - moves the character
  - draws the sprite
  - waits between frames
  - reverses direction after each run

## Requirements

- .NET SDK installed
- A terminal that supports console output

## Running the project

If this is inside a standard .NET console app, run:

```bash
dotnet run
```

## Project flow

`Program.cs` creates three characters and animates them one after another:

```csharp
Character goomba = new Goomba();
Character paraGoomba = new ParaGoomba();
Character GoombaAdv = new GoombaAdv();

GoombaAni ga1 = new GoombaAni(goomba);
GoombaAni ga2 = new GoombaAni(paraGoomba);
GoombaAni ga3 = new GoombaAni(GoombaAdv);

ga1.StartAni();
ga2.StartAni();
ga3.StartAni();
```

## Notes

- `GoombaAdv` alternates between left-facing and right-facing frames while moving to create a walking animation.
- `GoombaAni` controls the timing of the animation using `Thread.Sleep(...)`.
- The animation is terminal-based, so appearance may vary depending on your console width and font.

## Example

The program prints animated ASCII characters moving left and right across the screen.

## File overview

- `Character` — interface for all animated characters
- `Goomba` — basic Goomba sprite
- `ParaGoomba` — larger variant
- `GoombaAdv` — animated two-frame Goomba
- `GoombaAni` — animation controller
- `Program.cs` — entry point

## License

No license specified.