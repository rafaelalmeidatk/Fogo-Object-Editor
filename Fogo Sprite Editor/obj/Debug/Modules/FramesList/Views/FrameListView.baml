   M S B A M L   `   `   `  ����  Fogo Sprite Editor?    9Fogo_Sprite_Editor.Modules.FramesList.Views.FrameListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ ListBox��5      
������ $��0q�5   +   ��5   #   �� *Items+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   $��9 0 0 0q�6:   .+�5      ��    EnvironmentToolWindowText#���   6:    �� Padding$ 2q�6s   ��6$   �� *Name+6s   5      5      ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6&   �� *
Selected+ �� Value True6C   .a�5      ��  �� Property �@��
IsSelected	 �� Value	 . 6;   5      5       5"      �� 5$   
   $ Vertical=�6   $��1��5%      .+�5'      1  +Xceed.Wpf.Toolkit.PropertyGrid.PropertyGrid  -   5        
  Name$
 _propertyGrid��5'       $	��100��5(         ShowSummary .     ShowSortOptions .     IsCategorized .  $��0q�5-         ShowSearchBox .  ���#EEEEF2   SelectedObject 5)      �� *SelectedObject+5/      50      51      52      