   M S B A M L   `   `   `  ����D  @Metrology, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Metrology.ViewModelsMetrology.ViewModels  5   	   C&clr-namespace:Metrology.ViewModels.AddMetrology.ViewModels.Add  5   	   *    $Metrology.Views.AddViews.AddUserView   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   :viewModels1"clr-namespace:Metrology.ViewModels     5   	   6add&clr-namespace:Metrology.ViewModels.Add     5   	     � Title$  AddUserView��5
   	   $	��450��6   $	��400��6*   .��5      �  � 	Resources 5   
    �� MergedDictionaries �� Source   ActionButton �� 
TargetType  SimpleButton �� BasedOn �� Property �� Value�� 5       5      �� 5      $* $/Definitions/MetrologDictionary.xaml?�6)   %�  &	        7  '�� �     '��     '�� w    �� 5      " ��6-   8   .�5      ��  � ��$ 
20 30 20 0q�6/   �� 5       � ��$	 140��6.   �� 5       � ��$ 25��6/   5      �� 5      " ��6   .�5      ��  � ��$	 200��6.   �� 5       � ��$ 20��6/   5      �� 5      " ��6   .�5      ��  � ��$ 95��6.   �� 5       � ��$ 20��6/   5      �� 5      " ��6   .�5      ��  � ��$ 
10 10 10 0q�6/   5       5!      .+�5&   
   ��  �� Orientation$ Vertical=�6   .+�5'      �� $ 
Horizontal=�6   .+�5(      �� 
Имя :6$   �� 5)      ��6   �� *UserModel.Name+5*      �� 5+      $ 
Horizontal=�6   .+�5,      �� Фамилия :6(   �� 5-      ��6   �� 	 �� Path$	 UserModel.Surname�5.      �� 5/      $ 
Horizontal=�6   .+�50      �� Отчество :6)   �� 51      ��6   �� $	 UserModel.PatrName�52      �� 53      $ 
Horizontal=�6   .+�54      �� 
e-mail :6'   �� 55      ��6   �� $	 UserModel.Email�56      �� 57      $ 
Horizontal=�6   .+�58      �� День рождения :6.   (  "System.Windows.Controls.DatePicker  59      
   SelectedDate
 6   �� $	 UserModel.BirthDay�6P   5:      �� 5;      $ 
Horizontal=�6   .+�5<      �� Телефон :6(   �� 5=      ��6   �� $	 UserModel.Phone�5>      �� 5?      $ 
Horizontal=�6   .+�5@      �� Логин :6'   �� 5A      ��6   �� $	 UserModel.Login�5B      �� 5C      $ 
Horizontal=�6   .+�5D      �� Пароль :6(   �� 5E      ��6   �� $	 UserModel.Password�5F      �� 5G      $ 
Horizontal=�6   .+�5H      �� 
Роль :6&   �� 5I      $	��200��6    �� DisplayMemberPath$
 Name��5K      ��5J      �� *
RoleList+ �� SelectedItem 5L      �� $	 SelectedRole.Name�5N      �� 5O      $��Center=�6   $ 
Horizontal=�66   .+�5P      �� #��[  6   ��6A   �� *
SaveUser+.��6^   Сохранить5R      �� 5S      #��[  6   ��6@   �� $	 CloseCommand�.��6g   Отмена6o   5T      5U      5V      5W      