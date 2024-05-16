# Mastering Debugging with Visual Studio

## Creator

Joseph Guadagno

* [About Joe](http://jjg.me/aboutJJG)  - 'http://jjg.me/aboutJJG'
* Follow me on Twitter [@jguadagno](https://www.twitter.com/jguadagno)
* Email me at [jguadagno@hotmail.com](mailto:jguadagno@hotmail.com)
* [Website](http://www.josephguadagno.net)

## Reference

* [Mastering Debugging In Visual Studio](http://www.codeproject.com/Articles/79508/Mastering-Debugging-in-Visual-Studio-A-Beginn)
* [Debugger Documentation](https://learn.microsoft.com/en-us/visualstudio/debugger/?view=vs-2022&wt.mc_id=DT-MVP-4024623])

## Presentation

### Breakpoints

* Debugging with Breakpoints
  * Step Over
  * Step Into
  * Step Out
  * Continue
  * Set Next Statement
  * Show Next Statement
* Labeling in Break Point
* Conditional Breakpoint
* Import / Export Breakpoint
* Breakpoint Hit Count
* Breakpoint When Hit
* Breakpoint Filter

### Data Tip

* Pin Inspect Value During Debugging
* Drag-Drop Pin Data Tip
* Adding Comments
* Last Session Debugging Value
* Import Export Data Tips
* Change Value Using Data Tips
* Clear Data Tips

### Watch Windows

* Locals
* Autos
* Watch
  * Creating Object ID

### Immediate Window

### Call Stack

### Debugging Multithreaded Program (optional)

* Exploring Threads Window
* Flag Just My Code
* Break Point Filter - Multithread Debugging
* Debugging Parallel Program
* Parallel Task and Parallel Stacks

### Debugging with IntelliTrace (optional - speak to)

* Overview
* Mapping with IntelliTrace
* Filter IntelliTrace Data

### Useful Shortcut Keys for VS Debugging

| Shortcut Keys  | Descriptions                                                                                                      |
| -------------- | ----------------------------------------------------------------------------------------------------------------- |
| Ctrl-Alt-V, A  | Displays the Auto window                                                                                          |
| Ctrl-Alt-B     | Displays the Breakpoints dialog                                                                                   |
| Ctrl-Alt-C     | Displays the Call Stack                                                                                           |
| Ctrl-Shift-F9  | Clears all of the breakpoints in the project                                                                      |
| Ctrl-F9        | Enables or disables the breakpoint on the current line of code                                                    |
| Ctrl-Alt-E     | Displays the Exceptions dialog                                                                                    |
| Ctrl-Alt-I     | Displays the Immediate window                                                                                     |
| Ctrl-Alt-V, L  | Displays the Locals window                                                                                        |
| Ctrl-Alt-Q     | Displays the Quick Watch dialog                                                                                   |
| Ctrl-Shift-F5  | Terminates the current debugging session, rebuilds if necessary, and starts a new debugging session.              |
| Ctrl-F10       | Starts or resumes execution of your code and then halts execution when it reaches the selected statement.         |
| Ctrl-Shift-F10 | Sets the execution point to the line of code you choose                                                           |
| Alt-NUM *      | Highlights the next statement                                                                                     |
| F5             | If not currently debugging, this runs the startup project or projects and attaches the debugger.                  |
| Ctrl-F5        | Runs the code without invoking the debugger                                                                       |
| F11            | Step Into                                                                                                         |
| Shift-F11      | Executes the remaining lines out from procedure                                                                   |
| F10            | Executes the next line of code but does not step into any function calls                                          |
| Shift-F5       | Available in break and run modes, this terminates the debugging session                                           |
| Ctrl-Alt-H     | Displays the Threads window to view all of the threads for the current process                                    |
| F9             | Sets or removes a breakpoint at the current line                                                                  |
| Ctrl-Alt-W, 1  | Displays the Watch 1 window to view the values of variables or watch expressions                                  |
| Ctrl-Alt-P     | Displays the Processes dialog, which allows you to attach or detach the debugger to one or more running processes |
| Ctrl-D,V       | IntelliTrace Event                                                                                                |
