   M S B A M L   `   `   `  ����G  CWPFScheduler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFSchedulerWPFScheduler  5   	   !    WPFScheduler.DateViewWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPFScheduler     5   	     � Title$  Events��5   	   $	��450��6   $	��400��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6!   $��Events��5      $��40(�6"   $��0,0,0,20q�60   �� 5   
   -   5         ��Name$ eventsListView��5      $��2��6+   $��1��5       �� View 5      �� 5      .P�5       �� $��Event��6%    �� Width$	 200��64    �� DisplayMemberBinding 5!   %   �� *Name+5"      5$      �� 5&   
   $��2��6   $��3��6"    �� Orientation$ Vertical=�62   .+�5'      �� -   5         ��Name$ 	addButton��5'      $��30��6(   $	��100��64   $	��Add��5(      $��10,20q�6#   5)      �� 5*      -   5        $ removeButton��5*      $��30��6+   $	��100��67   $��Remove��5+      $��10,20q�6&   5,      �� 5-      -   5        $ detailsButton��5-      $��30��6,   $	��100��68   $��Details��5.      $��10,20q�6'   5/      �� 50      -   5        $ 
backButton��50      $��30��6)   $	��100��65   $
��Back��51      $��10,20q�6$   52      53      54      55      