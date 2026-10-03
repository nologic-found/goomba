# Goomba Console Animation

C# console program that renders animated ASCII Goombas in the terminal.

## Features

- Four character types:
  - `Goomba`: Regular Goomba 
  - `ParaGoomba`: Winged Goomba 
  - `GoombaAdv`: Two-frame walk cycle of Regualar Goomba
  - `Goomba2DPainter`: GoombaAdv moving in a square pattern with an asterisk (`*`) trail
- Shared `Character` interface (`Move`, `ChangeDirection`, `DrawSprites`)
- Animation is controlled by `GoombaAni`

## Requirements

- .NET SDK
- Terminal emulator with cursor-positioning support

## Usage

```bash
dotnet run
```