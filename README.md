# Separation Timer
A simplistic Windows application timer used for separation of traffic. This is a standalone program that will stay on top of all windows.

![2021-03-09 23_22_47-Separation Timer (Running) - Microsoft Visual Studio](https://user-images.githubusercontent.com/2505044/110549463-62bf8a80-8132-11eb-825e-028615b7d77d.png)

![2021-03-09 23_22_55-Separation Timer (Running) - Microsoft Visual Studio](https://user-images.githubusercontent.com/2505044/110549466-63582100-8132-11eb-9edf-34734ca26890.png)

## How to install
1. Download the newest release executable from [here](https://github.com/Vatsim-Scandinavia/separation-timer/releases)
2. Put the folder anywhere you'd like on your computer
3. Start the program when you need to use it

## Configure
The timer is by default 2 or 3 minutes. If you want other intervals, you can change them in `config.cfg`. Change the number of `one` or `two` to number of seconds. E.g. if you want first button to be 1 minute `one=60`. Restart the program after changes in settings.

## How to use
- Left click to start counting
- Right click to cancel

The timer turns yellow when it reaches 5 seconds and below, followed by an alert sound when it's done counting.

## Troubleshooting
If you should have issues running the program, make sure you've [.NET Runtime 5.0 installed](https://dotnet.microsoft.com/download).
