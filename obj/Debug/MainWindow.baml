   M S B A M L   `   `   `  ????M  ISwitchingViewsMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjectX_FrontendProjectX_Frontend  5   	   "    ProjectX_Frontend.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjectX_Frontend     5   	     ? Title$  BestAppEver??5   	   $	??500??6   $	??800??6*   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??1??6    ?? Orientation$ 
Horizontal=?6"   $??Center=?6;   $??4q?6X   .+?5      ?? -   5         ??Name$ menuHome??5      $	??200??6(   $
??Home??64   $
??Home??6i   $??45??6?   ???	#FF0062FF
???????
???????$??24(?5      ??5   C   ?? *UpdateViewCommand+5   L   ?? 5      -   5        $ menuAccount??5      $	??200??6*   $??Account??66   $??Account??6n   $??24(?6?   ???	#FF0062FF
???????
?????????6H   ?? *UpdateViewCommand+5   e   ?? 5      -   5        $ menuCat??5      $	??200??6&   $
??Cats??62   $	??Cat??6g   $??24(?6~   ???	#FF0062FF
???????
?????????6A   ?? *UpdateViewCommand+6?   5      ?? 5   
   ??6   ?? *SelectedViewModel+5      5      