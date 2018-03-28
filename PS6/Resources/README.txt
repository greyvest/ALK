10/27/2017

Kelsey Fink
Leona Craig

Design Choices:
	
	Made helper methods to encourage modularity throughout program. 
	Helper methods includes:
		- assign_content
		- getCellName
		- get_current_cell_selection
		- update_all_textboxes
		- update_name_textbox
		- update_value_textbox
		- update_content_textbox
		- update_NonEmpty_Cells

	Used a flag to determine whether or not the spreadsheet has been altered since last save.
	If user tries to close an unsaved spreadsheet a second time after warning, spreadsheet will close.

	Used SaveFileDialog and OpenFileDialog to handle Save and Open.
	The FileDialog already handles overwriting existing files with an appropriate warning message.

Additional Feature:
	
	First additional feature: 
		- "Need a boost" option in the menu bar
	This feature provides GIFs for when the user is needing a boost.
	We used free .gif files from the web
	Boost Categories:
		- Motivational
		- Funny
	
	Second additional feature:
		- Notified when changing content
	This feature changes the color of the content text to RED when the user is changing it.
	
Issues during PS6:

	Throughout our implementation of PS6 we encountered bugs that were often fixed by re-adding .dll files
	This appears to happen everytime we change something from a past assignment or change computers.


