   M S B A M L   `   `   `  ����K  GAnimaTechCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AnimaTechCreator.Views.UserControls#AnimaTechCreator.Views.UserControls  5      I)clr-namespace:AnimaTechCreator.ConvertersAnimaTechCreator.Converters  5      R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L5clr-namespace:System.Diagnostics;assembly=WindowsBaseSystem.Diagnostics 5	      7    1AnimaTechCreator.Views.UserControls.EffectControl   5      S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:AnimaTechCreator.Views.UserControls     5      @
converters)clr-namespace:AnimaTechCreator.Converters     5      Fdiag5clr-namespace:System.Diagnostics;assembly=WindowsBase     5	      $	��558��5
      $	��328��6+     � 	Resources  5      7   1AnimaTechCreator.Converters.ListToStringConverter   ListToStringConverterB   <AnimaTechCreator.Converters.OptionalCharacteristicsConverter $  OptionalCharacteristicsConverter��%:   &	        &	        5   
   6+     5   
   66   5      .��5      � 
�������$��
0,0,0,-237q�6"    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5       $
��Auto �6   6,   �� 5!      $
��Auto �6   $��28��6*   6;   �� 5"      $
��Auto �6   $��44��6*   6;   �� 5#      .+�5&   
   �� $��0��6   $
��Bold"�6$   $
��Left=�66   $��Center=�6Q   $��2��6l   $��16��6�   $��34,0,0,0q�6�   $��36��6�   	Effect:6�   �� 5'   
   -   5        $��
TestCmbBox��5'   D   $��0��6   $��1��6    $��3��60    �� DisplayMemberPath$
 Name��5*      ��5(      �� *EffectViews+ �� SelectedItem 5)      �� *SelectedView+ �� SelectedValue 5+      �� *SelectedView+ �� FallbackValue$ Please select a value��5,      �� 5.   
   $��1��6   $��8��6!   $��0,2,0,2q�65   6H   &   System.Windows.Controls.DataGrid  51   
   $��2��6   $��8��6    $
��Bold"�64      AutoGenerateColumns$ False��53      $
��Left=�54      $��3,0,0,0q�62   $	��552��6C   ��52      �� *SelectedViewCollection+  55      *  $System.Windows.Controls.DataGridCell �� 
TargetType	 �� Property
 �� Value��%V   '        �� 56      "  6   .�57      �� 	 � ��$
 Center=�6<   58      59         Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Ki��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *KiCost+6O     5<      $ Mk��6%    61   �� *MkCost+6N     5=      $ Maintenance��6%    6:   �� *MaintenanceCost+6`     5>      $ Minor Sustinence��6%    6?   �� *MinorSustinanceCost+6i     5?      $ Greator Sustinence��6%    6A   �� *GreatorSustinanceCost+6m     5@      $ Minimum Level��6%    6<   �� *MinimumLevelInt+6b   5B      �� 5D   
   $��3��6   $��8��6!   $��0,2,0,2q�65   6H   �� 5G   
   $��4��6   $��0��6!   $
��Bold"�61   $
��Left=�6C   $��Center=�6^   $��2��6y   $��16��6�   $��8,0,0,0q�6�   $��62��6�   
Frequency:6�   �� 5H   
   $��4��6   $��1��6    �� 
IsReadOnly$
 True��6/   $��2��6v   $��0,0,69,0q�6�   ��6A   �� *SelectedView.Frequency+ �� Mode$ OneWay=�6�   �� 5I   
   $��4��6   $��2��6!   $
��Bold"�61   $��Center=�6C   $��Center=�6`   $��16��6{   $��70��6�   Action Type:6�   �� 5J   
   $��4��6   $��3��6   $
 True��6/   $��1,0,0,0q�6w   ��6A   �� *SelectedView.ActionType+$ OneWay=�6�   �� 5K   
   $��4��6   $��4��6!   $��2��61   $
��Bold"�6E   $
��Left=�6W   $��Center=�6r   $��16��6�   $��12,0,0,0q�6�   $	��127��6�   Primary Characteristic:6�   �� 5L   
   $��4��6   $��5��6   $
 True��6/   $��2��6�   $��69,0,0,0q�6�   ��6A   �� *$"SelectedView.PrimaryCharacteristic+$ OneWay=�6�   �� 5N   
   $��5��6   $��1��6!   $��2��61   $
��Bold"�6E   $
��Left=�6W   $��6,0,0,0q�6r   $��64��6�   Element(s):6�   �� 5O   
   $��5��6   $��2��6   $��5��6/   $
 True��6C   ��5P      �� *SelectedView.Elements+ �� 	Converter# [  $ OneWay=�6}   �� 5R   
   $��6��6   $��0��6!   $��3��61   $
��Bold"�6E   $
��Left=�6W   $��44,0,0,0q�6r   $��96��6�   Optional Char(s).6�   �� 5S   
   $��6��6   $��2��6   $��5��6/   $
 True��6C   ��5T      �� *&$SelectedView.OptionalCharacteristics+# [ $ OneWay=�6�   �� 5U   
   $��7��6   $��0��6    $��8��60   $��0,5,0,0q�6D   $��Ki Costs��6U   $
��Bold"�6g     GroupBoxTab.Small#��[ 6y   .��5V      � -   5        $��
KiCostGrid��5V      5W      �� 5Y   
   -   5        $��OptionsGroupBox��5Y   �   $��8��6   $��0��6    $��8��60   $��0,5,0,10q�6D   $��Options��6V   $
��Bold"�6g   #��[ 6y   6�   5\      5]      