Converter:

Github:			https://github.com/icsharpcode/CodeConverter
VS Extension:	https://marketplace.visualstudio.com/items?itemName=SharpDevelopTeam.CodeConverter


--------


01 - Misc Examples
This one is just to show single file conversion

- Resulting C# will show
  - What happens with regions
  - What happens to single line code blocks

- Convert just the single file 'examples.vb' (in 'CodeConversion.MiscExamples') to C#


--------


02 - XAML Issues 
Converting a WPF assembly and fixing issues with XAML

(see file: 02 - XAML issues help.txt for guidance if needed)
(see file: 03 - XAML issues fixes.txt if you're completely stuck)

- Convert the assembly 'CodeConversion.XAMLIssues' to C#

- Fix XAML issues caused by conversion 

- Run 'CodeConversion.XAMLIssues', and confirm that you see an animated spinner 


--------


03 - Type Conversion
This is an example of some code that didn't originally have any tests around it;
It's been wrapped in characterization tests to make sure we don't break existing behaviour

- Convert the assembly 'CodeConversion.TypeConversion' to C#

- IMPORTANT: Ensure the reference from the test project to the newly converted projected is working
  (if not then remove and add the project reference again)

- Run tests to confirm conversion hasn't changed behaviour

- Remove the dependency on Microsoft.VisualBasic.CompilerServices and refactor to work without it

- Get tests passing