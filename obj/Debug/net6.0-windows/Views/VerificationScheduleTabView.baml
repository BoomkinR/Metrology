   M S B A M L   `   `   `  ����D  @Metrology, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Metrology.ViewsMetrology.Views  5      ;"clr-namespace:Metrology.ViewModelsMetrology.ViewModels  5      =#clr-namespace:Metrology.Models.DtosMetrology.Models.Dtos  5      1    +Metrology.Views.VerificationScheduleTabView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Metrology.Views     5      9
viewModels"clr-namespace:Metrology.ViewModels     5      4dtos#clr-namespace:Metrology.Models.Dtos     5      
�������.��5      �   � 	Resources  5   
    �� 
TargetType   ActionButton �� Property �� Value�� 5      %�   &	        �� 5      " ��6   .�5      ��  � ��$	 200��6.   �� 5       � ��$ 30��6/   �� 5       � ��$ 10q�6/   5      5       � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5      �� $��15q�6   $ Vertical=�6%   $	��100��6<   .+�5      �� $��Center=�6   $��С��69   (  "System.Windows.Controls.DatePicker  5      5       �� 5!      $��15q�6   $ Vertical=�6%   $	��100��6=   .+�5"      �� $��Center=�6   $
��По��69     5#      5$      �� 5%      $��15q�6   $ Vertical=�6%   $	��120��6=   .+�5&      �� $��Center=�6   $��Прибор��69   �� 5'      5(      �� 5)      $��15q�6   $ Vertical=�6%   $	��120��6=   .+�5*      �� ��6   ��  �� Path$ RefreshCommand�.��6B   Обновить6L   5+      5,      &   System.Windows.Controls.DataGrid  5.   
      	RowHeight$ 35Q�6   $��1��5/         AutoGenerateColumns$ False��51      	   SelectionMode$	 Single=�52      
   SelectionUnit$
 FullRow=�53      $ �� IsSynchronizedWithCurrentItem$
 TrueY�54      ��50      �� $ VerificationItems�   Columns 57      4  .System.Windows.Controls.DataGridTemplateColumn  58   
   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6!      Header 59      �� 5:      $��ID��6   $
��Wrap=�6(   $��Center=�6<   6\      CellTemplate 5<      �� 5=       �� DataType$! dtos:VerificationJournalDto��6   .R�5>      �� $ 
Horizontal=�6!   .+�5?      �� $��Center=�6)   ��6F   �� $ Id�5@      5A      5C        5E      $ * 6)    5F      �� 5G      $2��,Наименование, тип, номер��6    $
��Wrap=�6B   $��Center=�6V   6v    5I      �� 5J      $! dtos:VerificationJournalDto��6#   .R�5K      �� $ 
Horizontal=�6%   .+�5L      �� $��Center=�6)   ��5M   )   �� $ Device.Name� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�5N      5O      5Q        5S      $ * 6)    5T      �� 5U      $��Дата поверки��6    $
��Wrap=�66   $��Center=�6J   6j    5W      �� 5X      $! dtos:VerificationJournalDto��6#   .R�5Y      �� $ 
Horizontal=�6%   .+�5Z      �� $��Center=�6)   ��5[   )   �� $ VerificationDate�$ OneWay=�$ PropertyChanged=�5\      5]      5_        5o      $ * 6)    5p      �� 5q      $/��)Номер СИ в гос. реестре��6$   $
��Wrap=�6E   $��Center=�6Y   6y    5s      �� 5t      $! dtos:VerificationJournalDto��6'   .R�5u      �� $ 
Horizontal=�6)   .+�5v   "   �� $��Center=�6-   ��5w   )   �� $ Device.SerialNumber�5x      5y      5{        5}      $ * 6)    5~      �� 5      $1��+Поверяющая организация��6$   $
��Wrap=�6D   $��Center=�6X   6x    5�      �� 5�      $! dtos:VerificationJournalDto��6'   .R�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $��Center=�6-   ��5�   )   �� $ Organization.Name�5�      5�      5�        5�      $ * 6)    5�      �� 5�      $4��.Сроки проведения поверки��6$   $
��Wrap=�6F   $��Center=�6Z   6z    5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $��Center=�6-   $��неизвестно��5�   )   5�      5�      5�        5�      $ * 6)    5�      �� 5�      $3��-Сфера гос. регулирования��6$   $
��Wrap=�6F   $��Center=�6Z   6z    5�      �� 5�      $ dtos:DeviceDto��6'   .R�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $��Center=�6-   $��неизвестно��5�   )   5�      5�      5�      5�      5�      5�      