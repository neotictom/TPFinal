��U S E   [ m a s t e r ] 
 
 G O 
 
 / * * * * * *   O b j e c t :     D a t a b a s e   [ t e c h b u i l d ]         S c r i p t   D a t e :   8 / 1 1 / 2 0 2 3   0 8 : 5 2 : 1 1   * * * * * * / 
 
 C R E A T E   D A T A B A S E   [ t e c h b u i l d ] 
 
   C O N T A I N M E N T   =   N O N E 
 
   O N     P R I M A R Y   
 
 (   N A M E   =   N ' t e c h b u i l d ' ,   F I L E N A M E   =   N ' C : \ P r o g r a m   F i l e s \ M i c r o s o f t   S Q L   S e r v e r \ M S S Q L 1 4 . M S S Q L S E R V E R \ M S S Q L \ D A T A \ t e c h b u i l d . m d f '   ,   S I Z E   =   8 1 9 2 K B   ,   M A X S I Z E   =   U N L I M I T E D ,   F I L E G R O W T H   =   6 5 5 3 6 K B   ) 
 
   L O G   O N   
 
 (   N A M E   =   N ' t e c h b u i l d _ l o g ' ,   F I L E N A M E   =   N ' C : \ P r o g r a m   F i l e s \ M i c r o s o f t   S Q L   S e r v e r \ M S S Q L 1 4 . M S S Q L S E R V E R \ M S S Q L \ D A T A \ t e c h b u i l d _ l o g . l d f '   ,   S I Z E   =   8 1 9 2 K B   ,   M A X S I Z E   =   2 0 4 8 G B   ,   F I L E G R O W T H   =   6 5 5 3 6 K B   ) 
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   C O M P A T I B I L I T Y _ L E V E L   =   1 4 0 
 
 G O 
 
 I F   ( 1   =   F U L L T E X T S E R V I C E P R O P E R T Y ( ' I s F u l l T e x t I n s t a l l e d ' ) ) 
 
 b e g i n 
 
 E X E C   [ t e c h b u i l d ] . [ d b o ] . [ s p _ f u l l t e x t _ d a t a b a s e ]   @ a c t i o n   =   ' e n a b l e ' 
 
 e n d 
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A N S I _ N U L L _ D E F A U L T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A N S I _ N U L L S   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A N S I _ P A D D I N G   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A N S I _ W A R N I N G S   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A R I T H A B O R T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A U T O _ C L O S E   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A U T O _ S H R I N K   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A U T O _ U P D A T E _ S T A T I S T I C S   O N   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   C U R S O R _ C L O S E _ O N _ C O M M I T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   C U R S O R _ D E F A U L T     G L O B A L   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   C O N C A T _ N U L L _ Y I E L D S _ N U L L   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   N U M E R I C _ R O U N D A B O R T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   Q U O T E D _ I D E N T I F I E R   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   R E C U R S I V E _ T R I G G E R S   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T     D I S A B L E _ B R O K E R   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A U T O _ U P D A T E _ S T A T I S T I C S _ A S Y N C   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   D A T E _ C O R R E L A T I O N _ O P T I M I Z A T I O N   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   T R U S T W O R T H Y   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A L L O W _ S N A P S H O T _ I S O L A T I O N   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   P A R A M E T E R I Z A T I O N   S I M P L E   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   R E A D _ C O M M I T T E D _ S N A P S H O T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   H O N O R _ B R O K E R _ P R I O R I T Y   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   R E C O V E R Y   F U L L   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T     M U L T I _ U S E R   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   P A G E _ V E R I F Y   C H E C K S U M     
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   D B _ C H A I N I N G   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   F I L E S T R E A M (   N O N _ T R A N S A C T E D _ A C C E S S   =   O F F   )   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   T A R G E T _ R E C O V E R Y _ T I M E   =   6 0   S E C O N D S   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   D E L A Y E D _ D U R A B I L I T Y   =   D I S A B L E D   
 
 G O 
 
 E X E C   s y s . s p _ d b _ v a r d e c i m a l _ s t o r a g e _ f o r m a t   N ' t e c h b u i l d ' ,   N ' O N ' 
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   Q U E R Y _ S T O R E   =   O F F 
 
 G O 
 
 U S E   [ t e c h b u i l d ] 
 
 G O 
 
 / * * * * * *   O b j e c t :     U s e r   [ a l u m n o ]         S c r i p t   D a t e :   8 / 1 1 / 2 0 2 3   0 8 : 5 2 : 1 1   * * * * * * / 
 
 C R E A T E   U S E R   [ a l u m n o ]   F O R   L O G I N   [ a l u m n o ]   W I T H   D E F A U L T _ S C H E M A = [ d b o ] 
 
 G O 
 
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ P r o d u c t o s ]         S c r i p t   D a t e :   8 / 1 1 / 2 0 2 3   0 8 : 5 2 : 1 1   * * * * * * / 
 
 S E T   A N S I _ N U L L S   O N 
 
 G O 
 
 S E T   Q U O T E D _ I D E N T I F I E R   O N 
 
 G O 
 
 C R E A T E   T A B L E   [ d b o ] . [ P r o d u c t o s ] ( 
 
 	 [ I d P r o d ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L , 
 
 	 [ i m g ]   [ v a r c h a r ] ( 5 0 )   N O T   N U L L , 
 
 	 [ P r e c i o ]   [ i n t ]   N O T   N U L L , 
 
 	 [ C o n s u m o ]   [ i n t ]   N O T   N U L L , 
 
 	 [ N o m b r e P r o d ]   [ v a r c h a r ] ( 5 0 )   N O T   N U L L , 
 
   C O N S T R A I N T   [ P K _ P r o d u c t o s ]   P R I M A R Y   K E Y   C L U S T E R E D   
 
 ( 
 
 	 [ I d P r o d ]   A S C 
 
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ] 
 
 )   O N   [ P R I M A R Y ] 
 
 G O 
 
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ U s u a r i o ]         S c r i p t   D a t e :   8 / 1 1 / 2 0 2 3   0 8 : 5 2 : 1 1   * * * * * * / 
 
 S E T   A N S I _ N U L L S   O N 
 
 G O 
 
 S E T   Q U O T E D _ I D E N T I F I E R   O N 
 
 G O 
 
 C R E A T E   T A B L E   [ d b o ] . [ U s u a r i o ] ( 
 
 	 [ I d U s u a r i o ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L , 
 
 	 [ N o m b r e ]   [ n c h a r ] ( 1 0 )   N O T   N U L L , 
 
 	 [ A p e l l i d o ]   [ n c h a r ] ( 1 0 )   N O T   N U L L , 
 
 	 [ U s u a r i o ]   [ n c h a r ] ( 1 0 )   N O T   N U L L , 
 
 	 [ P r o d u c t o C o m p r a d o ]   [ i n t ]   N O T   N U L L , 
 
   C O N S T R A I N T   [ P K _ U s u a r i o ]   P R I M A R Y   K E Y   C L U S T E R E D   
 
 ( 
 
 	 [ I d U s u a r i o ]   A S C 
 
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ] 
 
 )   O N   [ P R I M A R Y ] 
 
 G O 
 
 A L T E R   T A B L E   [ d b o ] . [ U s u a r i o ]     W I T H   C H E C K   A D D     C O N S T R A I N T   [ F K _ U s u a r i o _ P r o d u c t o s ]   F O R E I G N   K E Y ( [ P r o d u c t o C o m p r a d o ] ) 
 
 R E F E R E N C E S   [ d b o ] . [ P r o d u c t o s ]   ( [ I d P r o d ] ) 
 
 G O 
 
 A L T E R   T A B L E   [ d b o ] . [ U s u a r i o ]   C H E C K   C O N S T R A I N T   [ F K _ U s u a r i o _ P r o d u c t o s ] 
 
 G O 
 
 U S E   [ m a s t e r ] 
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T     R E A D _ W R I T E   
 
 G O 
 
  
 G O 
 
 / * * * * * *   O b j e c t :     D a t a b a s e   [ t e c h b u i l d ]         S c r i p t   D a t e :   8 / 1 1 / 2 0 2 3   0 8 : 5 2 : 1 1   * * * * * * / 
 
 C R E A T E   D A T A B A S E   [ t e c h b u i l d ] 
 
   C O N T A I N M E N T   =   N O N E 
 
   O N     P R I M A R Y   
 
 (   N A M E   =   N ' t e c h b u i l d ' ,   F I L E N A M E   =   N ' C : \ P r o g r a m   F i l e s \ M i c r o s o f t   S Q L   S e r v e r \ M S S Q L 1 4 . M S S Q L S E R V E R \ M S S Q L \ D A T A \ t e c h b u i l d . m d f '   ,   S I Z E   =   8 1 9 2 K B   ,   M A X S I Z E   =   U N L I M I T E D ,   F I L E G R O W T H   =   6 5 5 3 6 K B   ) 
 
   L O G   O N   
 
 (   N A M E   =   N ' t e c h b u i l d _ l o g ' ,   F I L E N A M E   =   N ' C : \ P r o g r a m   F i l e s \ M i c r o s o f t   S Q L   S e r v e r \ M S S Q L 1 4 . M S S Q L S E R V E R \ M S S Q L \ D A T A \ t e c h b u i l d _ l o g . l d f '   ,   S I Z E   =   8 1 9 2 K B   ,   M A X S I Z E   =   2 0 4 8 G B   ,   F I L E G R O W T H   =   6 5 5 3 6 K B   ) 
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   C O M P A T I B I L I T Y _ L E V E L   =   1 4 0 
 
 G O 
 
 I F   ( 1   =   F U L L T E X T S E R V I C E P R O P E R T Y ( ' I s F u l l T e x t I n s t a l l e d ' ) ) 
 
 b e g i n 
 
 E X E C   [ t e c h b u i l d ] . [ d b o ] . [ s p _ f u l l t e x t _ d a t a b a s e ]   @ a c t i o n   =   ' e n a b l e ' 
 
 e n d 
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A N S I _ N U L L _ D E F A U L T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A N S I _ N U L L S   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A N S I _ P A D D I N G   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A N S I _ W A R N I N G S   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A R I T H A B O R T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A U T O _ C L O S E   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A U T O _ S H R I N K   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A U T O _ U P D A T E _ S T A T I S T I C S   O N   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   C U R S O R _ C L O S E _ O N _ C O M M I T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   C U R S O R _ D E F A U L T     G L O B A L   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   C O N C A T _ N U L L _ Y I E L D S _ N U L L   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   N U M E R I C _ R O U N D A B O R T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   Q U O T E D _ I D E N T I F I E R   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   R E C U R S I V E _ T R I G G E R S   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T     D I S A B L E _ B R O K E R   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A U T O _ U P D A T E _ S T A T I S T I C S _ A S Y N C   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   D A T E _ C O R R E L A T I O N _ O P T I M I Z A T I O N   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   T R U S T W O R T H Y   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   A L L O W _ S N A P S H O T _ I S O L A T I O N   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   P A R A M E T E R I Z A T I O N   S I M P L E   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   R E A D _ C O M M I T T E D _ S N A P S H O T   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   H O N O R _ B R O K E R _ P R I O R I T Y   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   R E C O V E R Y   F U L L   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T     M U L T I _ U S E R   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   P A G E _ V E R I F Y   C H E C K S U M     
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   D B _ C H A I N I N G   O F F   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   F I L E S T R E A M (   N O N _ T R A N S A C T E D _ A C C E S S   =   O F F   )   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   T A R G E T _ R E C O V E R Y _ T I M E   =   6 0   S E C O N D S   
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   D E L A Y E D _ D U R A B I L I T Y   =   D I S A B L E D   
 
 G O 
 
 E X E C   s y s . s p _ d b _ v a r d e c i m a l _ s t o r a g e _ f o r m a t   N ' t e c h b u i l d ' ,   N ' O N ' 
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T   Q U E R Y _ S T O R E   =   O F F 
 
 G O 
 
 U S E   [ t e c h b u i l d ] 
 
 G O 
 
 / * * * * * *   O b j e c t :     U s e r   [ a l u m n o ]         S c r i p t   D a t e :   8 / 1 1 / 2 0 2 3   0 8 : 5 2 : 1 1   * * * * * * / 
 
 C R E A T E   U S E R   [ a l u m n o ]   F O R   L O G I N   [ a l u m n o ]   W I T H   D E F A U L T _ S C H E M A = [ d b o ] 
 
 G O 
 
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ P r o d u c t o s ]         S c r i p t   D a t e :   8 / 1 1 / 2 0 2 3   0 8 : 5 2 : 1 1   * * * * * * / 
 
 S E T   A N S I _ N U L L S   O N 
 
 G O 
 
 S E T   Q U O T E D _ I D E N T I F I E R   O N 
 
 G O 
 
 C R E A T E   T A B L E   [ d b o ] . [ P r o d u c t o s ] ( 
 
 	 [ I d P r o d ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L , 
 
 	 [ i m g ]   [ v a r c h a r ] ( 5 0 )   N O T   N U L L , 
 
 	 [ P r e c i o ]   [ i n t ]   N O T   N U L L , 
 
 	 [ C o n s u m o ]   [ i n t ]   N O T   N U L L , 
 
 	 [ N o m b r e P r o d ]   [ v a r c h a r ] ( 5 0 )   N O T   N U L L , 
 
   C O N S T R A I N T   [ P K _ P r o d u c t o s ]   P R I M A R Y   K E Y   C L U S T E R E D   
 
 ( 
 
 	 [ I d P r o d ]   A S C 
 
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ] 
 
 )   O N   [ P R I M A R Y ] 
 
 G O 
 
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ U s u a r i o ]         S c r i p t   D a t e :   8 / 1 1 / 2 0 2 3   0 8 : 5 2 : 1 1   * * * * * * / 
 
 S E T   A N S I _ N U L L S   O N 
 
 G O 
 
 S E T   Q U O T E D _ I D E N T I F I E R   O N 
 
 G O 
 
 C R E A T E   T A B L E   [ d b o ] . [ U s u a r i o ] ( 
 
 	 [ I d U s u a r i o ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L , 
 
 	 [ N o m b r e ]   [ n c h a r ] ( 1 0 )   N O T   N U L L , 
 
 	 [ A p e l l i d o ]   [ n c h a r ] ( 1 0 )   N O T   N U L L , 
 
 	 [ U s u a r i o ]   [ n c h a r ] ( 1 0 )   N O T   N U L L , 
 
 	 [ P r o d u c t o C o m p r a d o ]   [ i n t ]   N O T   N U L L , 
 
   C O N S T R A I N T   [ P K _ U s u a r i o ]   P R I M A R Y   K E Y   C L U S T E R E D   
 
 ( 
 
 	 [ I d U s u a r i o ]   A S C 
 
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ] 
 
 )   O N   [ P R I M A R Y ] 
 
 G O 
 
 A L T E R   T A B L E   [ d b o ] . [ U s u a r i o ]     W I T H   C H E C K   A D D     C O N S T R A I N T   [ F K _ U s u a r i o _ P r o d u c t o s ]   F O R E I G N   K E Y ( [ P r o d u c t o C o m p r a d o ] ) 
 
 R E F E R E N C E S   [ d b o ] . [ P r o d u c t o s ]   ( [ I d P r o d ] ) 
 
 G O 
 
 A L T E R   T A B L E   [ d b o ] . [ U s u a r i o ]   C H E C K   C O N S T R A I N T   [ F K _ U s u a r i o _ P r o d u c t o s ] 
 
 G O 
 
 U S E   [ m a s t e r ] 
 
 G O 
 
 A L T E R   D A T A B A S E   [ t e c h b u i l d ]   S E T     R E A D _ W R I T E   
 
 G O 
 
 