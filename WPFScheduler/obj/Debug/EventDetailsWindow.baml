   M S B A M L   `   `   `  ����G  CWPFScheduler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFSchedulerWPFScheduler  5   	   %    WPFScheduler.EventDetailsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPFScheduler     5   	     � Title$  Event Details��5   	   $	��450��6   $	��300��6,   $��16(�68   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   �� $��Event Details��6   $��30(�6)   $��1��67   $��1��5      �� 5   
    �� Orientation$ Vertical=�6   $��2��6,   $��1��69   $
��0,20q�5      .+�5      �� $	��0,5q�5       ��5      �� *Name+ �� StringFormat$ 
Event: {0}��5       �� 5!      $	��0,5q�5"      ��5!      �� *Type+$ Event type: {0}��5"      �� 5#      $	��0,5q�5$   >   ��5#      �� *Start+$ Date: {0:dd MMMM yyyy}��5$   >   �� 5%      $	��0,5q�5&   8   ��5%      �� *Start+$ Start: {0:HH:mm}��5&   8   �� 5'      ��6   �� *End+$ End: {0:HH:mm}���� 5)      $��Description:��6   $��0,5,0,0q�6,   �� 5+      $
��Left=�5,      ��5+      �� *Description+5,      5/      �� 51   
   -   5         ��Name$ Close��51      $��1��6    $��4��60   $��30��6=   $	��100��52      $��Close��6   6-   54      55      