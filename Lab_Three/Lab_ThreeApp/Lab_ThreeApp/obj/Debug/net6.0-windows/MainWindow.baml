   M S B A M L   `   `   `  ????G  CLab_ThreeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lab_ThreeAppLab_ThreeApp  5   	       Lab_ThreeApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Lab_ThreeApp     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value??%  '??       '?? H     '?? ?     ?? 5
   
   " ??6   .?5      ??  ? ??$ 14(?6)   5      ?? 5   
   " ??6   .?5      ??  ? ??$ 14(?6)   5      ?? 5   
   " ??6   .?5      ??  ? ??$ 40??6&   ?? 5       ? ??$ 5q?6'   5      5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??0.8* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??0.2* ?6   .+?5   
   ?? $??0??6   ??6"   ?? *
Contacts+ ?? SelectedItem 5      ?? *SelectedContact+??5       ?? 5!      .R?5"      ?? $??5q?6!   .+?5#      ?? $??18(?6$   ??62   ??  ?? Path$
 Name??? 5$      ??6$   ?? $ Surname??? 5%      ??6$   ?? $ Phone?5&      5'      5)      ?? 5*   
   $??1??6   	 ?? Orientation$	 
Horizontal=?6"   .+?5+      ?? ??6   ?? *
AddCommand+.??64   +69   ?? 5,      ??6   ?? *RemoveCommand+??5-      ?? *SelectedContact+.??6B   -6G   5.      ?? 5/   
   $??1??6   
 ? DataContext
 6%   ?? *SelectedContact+.+?50      ?? $??	Contact: ??6   ?? 51      $
??Name??6   ?? 52      ??6   ?? *Name+ ?? UpdateSourceTrigger$ PropertyChanged=??? 53      $??Surname??6   ?? 54      ??6   ?? *	Surname+$ PropertyChanged=??? 55      $??Phone??6   ?? 56      ??6   ?? *Phone+$ PropertyChanged=?57      58      59      