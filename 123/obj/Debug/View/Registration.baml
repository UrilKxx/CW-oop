   M S B A M L   `   `   `  ����>  :123, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_123_123  5      clr-namespace:_123_123  5
          _123.View.Registration   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:_123     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      local1clr-namespace:_123  5
         MaterialDesignBody#���   5      $��Regular"�5   	   $��18(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5   	    N� Title$ Registration��5   	    � DataContext 6   �� *Registration+  Locator �� Source# [ .��5      )  #MaterialDesignThemes.Wpf.DialogHost     IsOpen 5   	   �� *IsOpenDialog+ �� FallbackValue$ False��	   DialogContent	 5   
   �� 5      $
��Auto��6   $
��Auto��6#   ._�5      �� $��16q�6   .+�5      �� ��6    �� *	Message+�� 5      $��0 10 0 0q�6    " MaterialDesignFlatAccentButton#��[ 6/   $��Закрыть��5   !   ���	#FFFF6D00$��90��6J   $��30��6U   ��6a   �� *CloseDialodCommand+5      5      .��5   
   �� 
 �� CornerRadius$
 25��6   $��35q�6#   ._�5    
   �� $��23q�6   .+�5!      �� $��Create your account��6   $��30(�63   $��Center=�6B   �� 5"      -   5        $��regUsername��5#      $
��0 10q�5$       ( $MaterialDesignFilledTextFieldTextBox#��[ 5%      $	��Top=�5&       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5(      $	��400��5)      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��5+      {�5,      ��  �� Path$ 	IsChecked� �� ElementName$9 3MaterialDesignFilledTextFieldTextBoxEnabledComboBox��.��6z   ��5-      �� 5.      $ Username�6    �� UpdateSourceTrigger$ PropertyChanged=�6.    �� ValidationRules 5/      !  _123.NotEmptyValidationRule  50        _123.MinimumCharacterRule  51         MinimumCharacters$ 3��69     _123.NotContainSpaceRule  52        _123.LoginValidationRule  53         _123.MaximumCharacterRule  54         MaximumCharacters$ 20��69   56      .��57       58      G� 5:      -   5        $��
regPassord��5;      $
��0 15q�5<      $	��Top=�5=      $ Password��5?       J� RenderTransformOrigin$ 0.494,0.469&�6?   $��72��6c   {�5>      �� *	IsChecked+$A ;MaterialDesignFilledPasswordFieldPasswordBoxEnabledComboBox����5@      �� 5A       �� 
TargetType" G�6    0 ,MaterialDesignFilledPasswordFieldPasswordBox �� BasedOn# [ 65   �5B      �� 5C      	  _123.PasswordBoxAssistant �� Property �@	 BindPassword �� Value . 6X   �� 5D       �@	 BoundPassword 5E   "   �� 5F   &   $ Password�6.   $ PropertyChanged=�6>    �� Mode$ TwoWay=�6d    5G   *     5H   .     5I   .   $ 6��6I     5J   .   
  _123.PasswordRule
  5K   .     5L   .   $ 24��6I   5N   '   5P      5R      5U      �� 5W      -   5         ��Name$	 reg��5W      $��Registration��6&   $
��60 0q�6=   
�������$��20(�6^   ��6m   �� *RegisterCommand+�� 5X      $��Center=�6   .��61   or65   �� 5Y      -   5        $ 	logsubmit��5Y      $��Login��6(   $
��60 0q�68   
�������$��20(�6Y   ��6g   �� *
logCommand+5[      5\      5]      5^      