   M S B A M L   `   `   `  ����G  CWPFScheduler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFSchedulerWPFScheduler  5   	        WPFScheduler.WeatherWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPFScheduler     5   	     � Title$  WeatherForecast��5   	   $	��550��6!   $	��400��6.   $��18(�5	   	   ��5
      �� 5   
    �� ImageSource$ Images/orangebg.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5       $��20 �6   .+�5#   
   �� $��1��6   $��1��6!   $��2��5$      $��Weather Forecast��5%      $��40(�6,   $��SemiBold"�5&      �� 5)   
   -   5         ��Name$ weatherIcon��5)      $��2��6%   $��2��5*      �� 5,   
   $��2��6   $��1��6!   $��25(�5.      $��Center=�5/      $��10q�50      ��5-      �� *Name+ �� Mode$ OneTime=�50      �� 52   
   $��3��6   $��1��6!   $��Center=�55      $��10q�56      ��53      �� *	Main.Temp+$ OneTime=� �� StringFormat$ Temperature: {0} °C��56      �� 58   
   $��4��6   $��1��6!   $��Center=�5;      $��10q�5<      ��59      �� *Main.Temp_min+$ OneTime=�$ Min. Temperature: {0} °C��5<      �� 5>   
   $��5��6   $��1��6!   $��Center=�5A      $��10q�5B      ��5?      �� *Main.Temp_max+$ OneTime=�$ Max. Temperature: {0} °C��5B      �� 5D   
   $��6��6   $��1��6!   $��Center=�5G      $��10q�5H      ��5E      �� *Main.Pressure+$ OneTime=�$ Pressure: {0} hPa��5H      �� 5J   
   $��7��6   $��1��6!   $��Center=�5M      $��10q�5N      ��5K      �� *Main.Humidity+$ OneTime=�$ Humidity: {0}%��5N      �� 5O   
   -   5         ��Name$ anotherCityButton��5O      $��9��6,   $��1��5P      $	��130��6!   $��40��6-   $��Different City��5Q      $
��Left=�5R      5S      �� 5U   
   -   5        $ closeButton��5U      $��9��6&   $��2��5V      $	��100��6!   $��40��6-   $��Close��5W      $��right=�5X      5Y      5[      5\      