   M S B A M L   `   `   `  ����J  FExample1Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Example1ProjectExample1Project  5   	   #    Example1Project.SumCalcWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Example1Project     5   	   -   5          � Title$  SumCalcWindow��5   	   $	��450��6   $	��800��6,   .��5	      �� .+�5
   
   �� -   5         ��Name$ 
lblNumber1��5
       �� Left$	 184��6(   $
��Wrap=�6:   $��Number 1��6N   
 �� Top$	 144��6^   $��18��6o   $��63��6{   �� 5   
   -   5        $ 
lblNumber2��5      $	 184��6(   $
��Wrap=�6:   $��Number 2��6N   $	 204��6^   $��13��6o   $��63��6{   �� 5   
   -   5        $ lblSum��5      $	 184��6$   $
��Wrap=�66   $	��Sum��6J   $	 265��6U    J� RenderTransformOrigin$ -0.073,-0.286&�6f   $��18��6�   $��63��6�   $��Center=�6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ 
txtNumber1��5      $	 322��6&    �� TextWrapping$
 Wrap=�68   $	 144��6L   $	��120��6]   $��Center=�6i   $	��Top=�6�   �� 5   
   -   5        $ 
txtNumber2��5      $	 322��6&   $
 Wrap=�68   $	 204��6L   $	��120��6]   $��Center=�6i   $��Center=�6�   �� 5   
   -   5        $ txtSum��5      $	 322��6"   $
 Wrap=�64   $	 265��6H   $	��120��6Y   $ 0.557,1.539&�6e   $��Center=�6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ 
btnFindSum��5      $��Find Sum��6%   $	 242��68   $	 309��6J   $��29��6[   $	��118��6g   6s   5      5      