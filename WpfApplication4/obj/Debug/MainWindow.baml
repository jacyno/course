   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    WpfApplication4    WpfApplication4.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          � Title$  Program��5   	   $��337.25��6   $	��525��6)    � 
ResizeMode$ CanMinimize=�6S   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Table��5      $
��Left=�6"   $��	10,10,0,0q�6=   $	��Top=�6P   $	��188��6h   $	��349��6u      AutoGenerateColumns .  � ContextMenu 5      �� 5      .@�5      m� -   5        $#��Добавить запись��5      68   m� 5      -   5        $��Изменить��5      61   m� 5      -   5        $��Удалить��5      60   5      5      �� 5   
   -   5         ��Name$ Button1��5      $��Добавить��6"   $
��Left=�65   $��
10,203,0,0q�6P   $	��Top=�6d   $��81��6|   6�   	� 5   
   -   5         	�Name$ RadioTxt��5      $��Текстовой��6(   $
��Left=�6<   $��
390,42,0,0q�6W   $	��Top=�6k    d� 	IsChecked$
 TrueY�6�   	� 5   
   -   5        $ RadioBin��5      $��Бинарный��6(   $
��Left=�6;   $��
390,65,0,0q�6V   $	��Top=�6j   6�   	� 5   
   -	   5        $ RadioMemory��5      $��В памяти��6+   $
��Left=�6>   $��
390,88,0,0q�6Y   $	��Top=�6m   6�   �� 5   
   $(��"Выбор репозитория:��6   $
��Left=�6-   $��
364,11,0,0q�6H   $	��Top=�6\   $	��127��6t   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��119��6T   $��
366,11,0,0q�6a   $	��Top=�6u   $	��127��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��187��6T   $��5,11,0,0q�6a   $	��Top=�6s   $	��354��6�   �� 5   
   -
   5        $ BtnFile��5      $��Выбор файла...��6"   $
��Left=�6;   $��390,135,0,0q�6V   $	��Top=�6k   $	��101��6�   6�   �� 5   
   -   5        $ Button2��5      $��Изменить��6"   $
��Left=�65   $��
96,203,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ Button3��5      $��Удалить��6"   $
��Left=�64   $��176,203,0,0q�6O   $	��Top=�6d   $��74��6|   6�   �� 5   
   -   5         ��Name$ 	BoxFields��5      $
��Left=�6&   $��103,233,0,0q�6A   $	��Top=�6V   $	��147��6n   	 �� SelectedIndex$	 0��6z   
 �� ItemBindingGroup
 5       &   System.Windows.Data.BindingGroup  5!      5#      �� 5$   
   -   5        $��
Поиск��5$      $
��Left=�6!   $��175,264,0,0q�6<   $	��Top=�6Q   $��75��6i   6t   �� 5%   
   -   5         ��Name$ 
TextSearch��5%      $
��Left=�6&   $��23��6A   $��
10,264,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��160��6�   �� 5&   
   $ ��Искать в поле: ��6   $
��Left=�6*   $��
10,233,0,0q�6E   $	��Top=�6Y   5'      5(      