   M S B A M L   `   `   `  ����D  @Metrology, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Metrology.ViewModels.AddMetrology.ViewModels.Add  5   	   1    +Metrology.Views.AddViews.AddDeviceModalView   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   6add&clr-namespace:Metrology.ViewModels.Add     5   	     � Title$#  Добавить прибор��5	   	   $	��450��6!   $	��400��6.   .��5
      �  � 	Resources 5   
    �� MergedDictionaries �� Source   ActionButton �� 
TargetType  SimpleButton �� BasedOn �� Property �� Value�� 5       5      �� 5      $* $/Definitions/MetrologDictionary.xaml?�6)   %�  &	        7  '�� �     '�� 3    '�� �    '�� Z    �� 5      " ��6-   8   .�5      ��  � ��$ 
20 30 20 0q�6/   �� 5       � ��$	 140��6.   �� 5       � ��$ 25��6/   5      �� 5      " ��6   .�5      ��  � ��$	 200��6.   �� 5       � ��$ 20��6/   �� 5       � ��$ Center=�6:   5      �� 5      " ��6   .�5      ��  � ��$	 200��6.   �� 5       � ��$ 20��6/   �� 5       � ��$ Center=�6:   5      �� 5      " ��6   .�5       ��  � ��$
 Wrap=�65   �� 5!       � ��$ 95��6.   �� 5"       � ��$ 20��62   5#      �� 5$      " ��6   .�5%      ��  � ��$ 
10 10 10 0q�6/   5&      5'      .+�5,   
   ��  �� Orientation$ Vertical=�6   .+�5-      �� $ 
Horizontal=�6   .+�5.      �� 
Имя :6$   �� 5/      ��6   �� *Device.Name+50      �� 51      $ 
Horizontal=�6   .+�52      �� 
Тип :6$   �� 53      	 �� DisplayMemberPath$
	 Name��55      ��53      �� 
 �� Path$
 DeviceTypes� �� SelectedItem 54      �� $
 SelectedDeviceType�55      56      �� 57      $ 
Horizontal=�6   .+�58      �� Дата создания :6.   (  "System.Windows.Controls.DatePicker  59         SelectedDate 6   �� $
 Device.DeviceDate�5:      �� 5;      $ 
Horizontal=�6   .+�5<      �� 97Дата введения в эксплуатацию :6<     5=       6   �� $!
 Device.DateExplotationStart�5>      �� 5?      $ 
Horizontal=�6   .+�5@      �� 75Дата поверки в эксплуатацию :6;     5A       6   �� $
 Device.DeviceDate�5B      �� 5C      $ 
Horizontal=�6   .+�5D      �� Серийный номер :6/   �� 5E      ��6   �� $
 Device.SerialNumber�5F      �� 5G      $ 
Horizontal=�6   .+�5H      �� Локация :6'   �� 5I      $
	 Name��5J       5I      �� $
 Device.Location���5K      �� $
 	Locations�5L      �� 5N      $ 
Horizontal=�6   .+�5O      �� Дата поверки :6,     5P       6   �� $*
 $VerificationJournal.VerificationDate�5Q      �� 5S      $ 
Horizontal=�6   .+�5T      �� Организация :6+   �� 5U      $
	 Name��5V       5U      �� $&
  VerificationJournal.Organization���5W      �� $
 Organizations�5X      �� 5Z      $��Center=�6   $ 
Horizontal=�66   .+�5[      �� #��[  6   ��6A   �� *
AddCommand+.��6`   Сохранить5]      �� 5^      #��[  6   ��6@   �� $
 CloseCommand�.��6f   Отмена6n   5_      5`      5a      5b      