   M S B A M L   `   `   `  ����G  CWPFScheduler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFSchedulerWPFScheduler  5   	   !    WPFScheduler.ToDoListWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPFScheduler     5   	     � Title$  ToDoListWindow��5   	   $	��600��6    $	��500��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6!   $��
To Do List��61   $��3��5      $��42(�6(   �� 5   
   -   5        $��tasksToDoListView��5    %   $��2��5      $��1��6    $��3��60   $��0,20,0,0q�5        �� View 5!      �� 5"      .P�5#      �� $
��Task��6%    �� Width$	 180��63    �� DisplayMemberBinding 5$   %   �� *Name+�� 5%      $
��Type��6%   $ 80��63    5&   %   �� *Type+�� 5'      $��Deadline��6%   $	 150��67    5(   %   �� *
Deadline+ �� StringFormat$ dd-MMMM-yyyy HH:mm��5)      5+      �� 5-   
   -   5         ��Name$ 
backButton��5-      $��30��6%   $	��100��61   $��1��5.      $��4��6!   $
��Back��6.   5/      �� 51   
   -   5        $ removeButton��51      $��30��6'   $	��100��63   $��2��52      $��4��6!   $��Remove��6.   53      �� 55   
   -   5        $ 	addButton��55      $��30��6$   $	��100��60   $��3��56      $��4��6!   $	��Add��6.   57      58      59      