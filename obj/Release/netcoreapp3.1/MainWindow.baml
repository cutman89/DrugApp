   M S B A M L   `   `   `  ���� B  >DrugApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DrugAppDrugApp      DrugApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:DrugApp       � Title$  DrugAdd��$	��500��$	��800������  �� ImageSource$ Image/6881.jpg��.���  � ColumnDefinitions �� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto �.+�� $��0��$��Center=� �� $
��Auto ��� $	��200 � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��Numero��$��0��$��0���� -    ��Name$ numero��$��0��$��1��$��Center=�$��20���� $	��Nom��$��1��$��0��$��0,20,0,0q��� -   $	 nom��$��1��$��1��$��Center=�$��0,20,0,0q�$��20���� $��Molecule��$��2��$��0��$��0,20,0,0q��� -   $ molecule�� �� TextWrapping$
 Wrap=�$��2��$��1��$��Center=�$��0,20,0,0q�$��80��" �� VerticalScrollBarVisibility$ Visible=� �� AcceptsReturn$
 True���� $��Posolgie��$��3��$��0��$��0,20,0,0q��� -   $ 	posologie��$
 Wrap=�$��3��$��1��$��Center=�$ Visible=�$
 True��$��0,20,0,0q�$��80���� $��Contre-indication��$��4��$��0��$��0,20,0,0q��� -   $ contreindication��$
 Wrap=�$��4��$��1��$��Center=�$��0,20,0,0q�$��80��$ Visible=�$
 True��� $��1��$��Center=� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   $	��Add��$��1��$��0��$	��top=�$	��100��$��	40,10,0,0q�$��50���� -   $��Modify��$��1��$	��Top=�$	��100��$��	40,10,0,0q�$��50����  �� CornerRadius$ 10��$��2��$	��Top=�$	��100��$��	40,10,0,0q�$��1q�._��� -   $��	Supprimer��$��50���� -	   $��	Affichage��$��1��$��3��$	��top=�$	��100��$��	40,10,0,0q�$��50��