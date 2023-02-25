<%@ Page Title="" Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Birds_Guide.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <header>
        <h1>SIGN UP</h1>
    </header>
  
    <div class="containerS">
     <fieldset>
            <legend>SIGN UP:</legend>
           <form class="form" runat="server" enctype="multipart/form-data">
               <%=message %>
                <label>Username:</label>
                    <input class="input" type="text" id="username" name="username" onchange="inputusername()"/>
                            <p id="UsernameP" class="pStyle"></p> 
                   <label>Email:</label>
                        <input class="input" type="email" id="email" name="email" onchange="inputEmail()"/>
                               <p id="EmailP" class="pStyle"></p> 

                    <label>Phone:</label>
                        <input class="input" type="text" id="phone" name="phone" onchange="inputPhone()"/>
                               <p  id="PhoneP" class="pStyle"></p> 

               <label>Password:</label>
                        <input class="input" type="password" id="password" name="password" onchange="inputpassword()"/>
                               <p  id="PassP" class="pStyle"></p> 
               <label>Password Varification:</label>
                        <input class="input" type="password" id="passwordV" name="passwordV" onchange="PasswordV()">
                               <p  id="PassVP" class="pStyle"></p> 

              <br />  <label>
               show password<input type="checkbox" onclick="passwordTransform()"> 
             </label>
               <label for="image">image</label>
               <asp:FileUpload id="image" name="image" runat="server"/>
                <label> Gender: </label>   
                <select id="genderddl" name="gender">
                        <option id="female" value="female" selected="selected">female</option>
                        <option id="male"   value="male"  >male</option>
                        <option id="other"  value="other" >other</option>
                </select>
                 <label>Country: </label>    
                 <select id="countryddl" name="country">
                        <option id="Afganistan"                 value="Afganistan"               >Afghanistan</option>
                        <option id="Albania"                    value="Albania"                  >Albania</option>
                        <option id="Algeria"                    value="Algeria"                  >Algeria</option>
                        <option id="American Samoa"             value="American Samoa"           >American Samoa</option>
                        <option id="Andorra"                    value="Andorra"                  >Andorra</option>
                        <option id="Angola"                     value="Angola"                   >Angola</option>
                        <option id="Anguilla"                   value="Anguilla"                 >Anguilla</option>
                        <option id="Antigua & Barbuda"          value="Antigua & Barbuda"        >Antigua & Barbuda</option>
                        <option id="Argentina"                  value="Argentina"                >Argentina</option>
                        <option id="Armenia"                    value="Armenia"                  >Armenia</option>
                        <option id="Aruba"                      value="Aruba"                    >Aruba</option>
                        <option id="Australia"                  value="Australia"                >Australia</option>
                        <option id="Austria"                    value="Austria"                  >Austria</option>
                        <option id="Azerbaijan"                 value="Azerbaijan"               >Azerbaijan</option>
                        <option id="Bahamas"                    value="Bahamas"                  >Bahamas</option>
                        <option id="Bahrain"                    value="Bahrain"                  >Bahrain</option>
                        <option id="Bangladesh"                 value="Bangladesh"               >Bangladesh</option>
                        <option id="Barbados"                   value="Barbados"                 >Barbados</option>
                        <option id="Belarus"                    value="Belarus"                  >Belarus</option>
                        <option id="Belgium"                    value="Belgium"                  >Belgium</option>
                        <option id="Belize"                     value="Belize"                   >Belize</option>
                        <option id="Benin"                      value="Benin"                    >Benin</option>
                        <option id="Bermuda"                    value="Bermuda"                  >Bermuda</option>
                        <option id="Bhutan"                     value="Bhutan"                   >Bhutan</option>
                        <option id="Bolivia"                    value="Bolivia"                  >Bolivia</option>
                        <option id="Bonaire"                    value="Bonaire"                  >Bonaire</option>
                        <option id="Bosnia & Herzegovina"       value="Bosnia & Herzegovina"     >Bosnia & Herzegovina</option>
                        <option id="Botswana"                   value="Botswana"                 >Botswana</option>
                        <option id="Brazil"                     value="Brazil"                   >Brazil</option>
                        <option id="British Indian Ocean Ter"   value="British Indian Ocean Ter" >British Indian Ocean Ter</option>
                        <option id="Brunei"                     value="Brunei"                   >Brunei</option>
                        <option id="Bulgaria"                   value="Bulgaria"                 >Bulgaria</option>
                        <option id="Burkina Faso"               value="Burkina Faso"             >Burkina Faso</option>
                        <option id="Burundi"                    value="Burundi"                  >Burundi</option>
                        <option id="Cambodia"                   value="Cambodia"                 >Cambodia</option>
                        <option id="Cameroon"                   value="Cameroon"                 >Cameroon</option>
                        <option id="Canada"                     value="Canada"                   >Canada</option>
                        <option id="Canary Islands"             value="Canary Islands"           >Canary Islands</option>
                        <option id="Cape Verde"                 value="Cape Verde"               >Cape Verde</option>
                        <option id="Cayman Islands"             value="Cayman Islands"           >Cayman Islands</option>
                        <option id="Central African Republic"   value="Central African Republic" >Central African Republic</option>
                        <option id="Chad"                       value="Chad"                     >Chad</option>
                        <option id="Channel Islands"            value="Channel Islands"          >Channel Islands</option>
                        <option id="Chile"                      value="Chile"                    >Chile</option>
                        <option id="China"                      value="China"                    >China</option>
                        <option id="Christmas Island"           value="Christmas Island"         >Christmas Island</option>
                        <option id="Cocos Island"               value="Cocos Island"             >Cocos Island</option>
                        <option id="Colombia"                   value="Colombia"                 >Colombia</option>
                        <option id="Comoros"                    value="Comoros"                  >Comoros</option>
                        <option id="Congo"                      value="Congo"                    >Congo</option>
                        <option id="Cook Islands"               value="Cook Islands"             >Cook Islands</option>
                        <option id="Costa Rica"                 value="Costa Rica"               >Costa Rica</option>
                        <option id="Cote DIvoire"               value="Cote DIvoire"             >Cote DIvoire</option>
                        <option id="Croatia"                    value="Croatia"                  >Croatia</option>
                        <option id="Cuba"                       value="Cuba"                     >Cuba</option>
                        <option id="Curaco"                     value="Curaco"                   >Curacao</option>
                        <option id="Cyprus"                     value="Cyprus"                   >Cyprus</option>
                        <option id="Czech Republic"             value="Czech Republic"           >Czech Republic</option>
                        <option id="Denmark"                    value="Denmark"                  >Denmark</option>
                        <option id="Djibouti"                   value="Djibouti"                 >Djibouti</option>
                        <option id="Dominica"                   value="Dominica"                 >Dominica</option>
                        <option id="Dominican Republic"         value="Dominican Republic"       >Dominican Republic</option>
                        <option id="East Timor"                 value="East Timor"               >East Timor</option>
                        <option id="Ecuador"                    value="Ecuador"                  >Ecuador</option>
                        <option id="Egypt"                      value="Egypt"                    >Egypt</option>
                        <option id="El Salvador"                value="El Salvador"              >El Salvador</option>
                        <option id="Equatorial Guinea"          value="Equatorial Guinea"        >Equatorial Guinea</option>
                        <option id="Eritrea"                    value="Eritrea"                  >Eritrea</option>
                        <option id="Estonia"                    value="Estonia"                  >Estonia</option>
                        <option id="Ethiopia"                   value="Ethiopia"                 >Ethiopia</option>
                        <option id="Falkland Islands"           value="Falkland Islands"         >Falkland Islands</option>
                        <option id="Faroe Islands"              value="Faroe Islands"            >Faroe Islands</option>
                        <option id="Fiji"                       value="Fiji"                     >Fiji</option>
                        <option id="Finland"                    value="Finland"                  >Finland</option>
                        <option id="France"                     value="France"                   >France</option>
                        <option id="French Guiana"              value="French Guiana"            >French Guiana</option>
                        <option id="French Polynesia"           value="French Polynesia"         >French Polynesia</option>
                        <option id="French Southern Ter"        value="French Southern Ter"      >French Southern Ter</option>
                        <option id="Gabon"                      value="Gabon"                    >Gabon</option>
                        <option id="Gambia"                     value="Gambia"                   >Gambia</option>
                        <option id="Georgia"                    value="Georgia"                  >Georgia</option>
                        <option id="Germany"                    value="Germany"                  >Germany</option>
                        <option id="Ghana"                      value="Ghana"                    >Ghana</option>
                        <option id="Gibraltar"                  value="Gibraltar"                >Gibraltar</option>
                        <option id="Great Britain"              value="Great Britain"            >Great Britain</option>
                        <option id="Greece"                     value="Greece"                   >Greece</option>
                        <option id="Greenland"                  value="Greenland"                >Greenland</option>
                        <option id="Grenada"                    value="Grenada"                  >Grenada</option>
                        <option id="Guadeloupe"                 value="Guadeloupe"               >Guadeloupe</option>
                        <option id="Guam"                       value="Guam"                     >Guam</option>
                        <option id="Guatemala"                  value="Guatemala"                >Guatemala</option>
                        <option id="Guinea"                     value="Guinea"                   >Guinea</option>
                        <option id="Guyana"                     value="Guyana"                   >Guyana</option>
                        <option id="Haiti"                      value="Haiti"                    >Haiti</option>
                        <option id="Hawaii"                     value="Hawaii"                   >Hawaii</option>
                        <option id="Honduras"                   value="Honduras"                 >Honduras</option>
                        <option id="Hong Kong"                  value="Hong Kong"                >Hong Kong</option>
                        <option id="Hungary"                    value="Hungary"                  >Hungary</option>
                        <option id="Iceland"                    value="Iceland"                  >Iceland</option>
                        <option id="Indonesia"                  value="Indonesia"                >Indonesia</option>
                        <option id="India"                      value="India"                    >India</option>
                        <option id="Iran"                       value="Iran"                     >Iran</option>
                        <option id="Iraq"                       value="Iraq"                     >Iraq</option>
                        <option id="Ireland"                    value="Ireland"                  >Ireland</option>
                        <option id="Isle of Man"                value="Isle of Man"              >Isle of Man</option>
                        <option id="Israel"                   value="Israel" selected ="selected">Israel</option>
                        <option id="Italy"                      value="Italy"                    >Italy</option>
                        <option id="Jamaica"                    value="Jamaica"                  >Jamaica</option>
                        <option id="Japan"                      value="Japan"                    >Japan</option>
                        <option id="Jordan"                     value="Jordan"                   >Jordan</option>
                        <option id="Kazakhstan"                 value="Kazakhstan"               >Kazakhstan</option>
                        <option id="Kenya"                      value="Kenya"                    >Kenya</option>
                        <option id="Kiribati"                   value="Kiribati"                 >Kiribati</option>
                        <option id="Korea North"                value="Korea North"              >Korea North</option>
                        <option id="Korea Sout"                 value="Korea Sout"               >Korea South</option>
                        <option id="Kuwait"                     value="Kuwait"                   >Kuwait</option>
                        <option id="Kyrgyzstan"                 value="Kyrgyzstan"               >Kyrgyzstan</option>
                        <option id="Laos"                       value="Laos"                     >Laos</option>
                        <option id="Latvia"                     value="Latvia"                   >Latvia</option>
                        <option id="Lebanon"                    value="Lebanon"                  >Lebanon</option>
                        <option id="Lesotho"                    value="Lesotho"                  >Lesotho</option>
                        <option id="Liberia"                    value="Liberia"                  >Liberia</option>
                        <option id="Libya"                      value="Libya"                    >Libya</option>
                        <option id="Liechtenstein"              value="Liechtenstein"            >Liechtenstein</option>
                        <option id="Lithuania"                  value="Lithuania"                >Lithuania</option>
                        <option id="Luxembourg"                 value="Luxembourg"               >Luxembourg</option>
                        <option id="Macau"                      value="Macau"                    >Macau</option>
                        <option id="Macedonia"                  value="Macedonia"                >Macedonia</option>
                        <option id="Madagascar"                 value="Madagascar"               >Madagascar</option>
                        <option id="Malaysia"                   value="Malaysia"                 >Malaysia</option>
                        <option id="Malawi"                     value="Malawi"                   >Malawi</option>
                        <option id="Maldives"                   value="Maldives"                 >Maldives</option>
                        <option id="Mali"                       value="Mali"                     >Mali</option>
                        <option id="Malta"                      value="Malta"                    >Malta</option>
                        <option id="Marshall Islands"           value="Marshall Islands"         >Marshall Islands</option>
                        <option id="Martinique"                 value="Martinique"               >Martinique</option>
                        <option id="Mauritania"                 value="Mauritania"               >Mauritania</option>
                        <option id="Mauritius"                  value="Mauritius"                >Mauritius</option>
                        <option id="Mayotte "                   value="Mayotte "                 >Mayotte</option>
                        <option id="Mexico"                     value="Mexico"                   >Mexico</option>
                        <option id="Midway Islands"             value="Midway Islands"           >Midway Islands</option>
                        <option id="Moldova"                    value="Moldova"                  >Moldova</option>
                        <option id="Monaco"                     value="Monaco"                   >Monaco</option>
                        <option id="Mongolia"                   value="Mongolia"                 >Mongolia</option>
                        <option id="Montserrat"                 value="Montserrat"               >Montserrat</option>
                        <option id="Morocco"                    value="Morocco"                  >Morocco</option>
                        <option id="Mozambique"                 value="Mozambique"               >Mozambique</option>
                        <option id="Myanmar"                    value="Myanmar"                  >Myanmar</option>
                        <option id="Nambia"                     value="Nambia"                   >Nambia</option>
                        <option id="Nauru"                      value="Nauru"                    >Nauru</option>
                        <option id="Nepal"                      value="Nepal"                    >Nepal</option>
                        <option id="Netherland Antilles"        value="Netherland Antilles"      >Netherland Antilles</option>
                        <option id="Netherlands"                value="Netherlands"              >Netherlands (Holland, Europe)</option>
                        <option id="Nevis"                      value="Nevis"                    >Nevis</option>
                        <option id="New Caledonia"              value="New Caledonia"            >New Caledonia</option>
                        <option id="New Zealand"                value="New Zealand"              >New Zealand</option>
                        <option id="Nicaragua"                  value="Nicaragua"                >Nicaragua</option>
                        <option id="Niger"                      value="Niger"                    >Niger</option>
                        <option id="Nigeria"                    value="Nigeria"                  >Nigeria</option>
                        <option id="Niue"                       value="Niue"                     >Niue</option>
                        <option id="Norfolk Island"             value="Norfolk Island"           >Norfolk Island</option>
                        <option id="Norway"                     value="Norway"                   >Norway</option>
                        <option id="Oman"                       value="Oman"                     >Oman</option>
                        <option id="Pakistan"                   value="Pakistan"                 >Pakistan</option>
                        <option id="Palau Island"               value="Palau Island"             >Palau Island</option>
                        <option id="Palestine"                  value="Palestine"                >Palestine</option>
                        <option id="Panama"                     value="Panama"                   >Panama</option>
                        <option id="Papua New Guinea"           value="Papua New Guinea"         >Papua New Guinea</option>
                        <option id="Paraguay"                   value="Paraguay"                 >Paraguay</option>
                        <option id="Peru"                       value="Peru"                     >Peru</option>
                        <option id="Phillipines"                value="Phillipines"              >Philippines</option>
                        <option id="Pitcairn Island"            value="Pitcairn Island"          >Pitcairn Island</option>
                        <option id="Poland"                     value="Poland"                   >Poland</option>
                        <option id="Portugal"                   value="Portugal"                 >Portugal</option>
                        <option id="Puerto Rico"                value="Puerto Rico"              >Puerto Rico</option>
                        <option id="Qatar"                      value="Qatar"                    >Qatar</option>
                        <option id="Republic of Montenegro"     value="Republic of Montenegro"   >Republic of Montenegro</option>
                        <option id="Republic of Serbia"         value="Republic of Serbia"       >Republic of Serbia</option>
                        <option id="Reunion"                    value="Reunion"                  >Reunion</option>
                        <option id="Romania"                    value="Romania"                  >Romania</option>
                        <option id="Russia"                     value="Russia"                   >Russia</option>
                        <option id="Rwanda"                     value="Rwanda"                   >Rwanda</option>
                        <option id="St Barthelemy"              value="St Barthelemy"            >St Barthelemy</option>
                        <option id="St Eustatius"               value="St Eustatius"             >St Eustatius</option>
                        <option id="St Helena"                  value="St Helena"                >St Helena</option>
                        <option id="St Kitts-Nevis"             value="St Kitts-Nevis"           >St Kitts-Nevis</option>
                        <option id="St Lucia"                   value="St Lucia"                 >St Lucia</option>
                        <option id="St Maarten"                 value="St Maarten"               >St Maarten</option>
                        <option id="St Pierre & Miquelon"       value="St Pierre & Miquelon"     >St Pierre & Miquelon</option>
                        <option id="St Vincent & Grenadines"    value="St Vincent & Grenadines"  >St Vincent & Grenadines</option>
                        <option id="Saipan"                     value="Saipan"                   >Saipan</option>
                        <option id="Samoa"                      value="Samoa"                    >Samoa</option>
                        <option id="Samoa American"             value="Samoa American"           >Samoa American</option>
                        <option id="San Marino"                 value="San Marino"               >San Marino</option>
                        <option id="Sao Tome & Principe"        value="Sao Tome & Principe"      >Sao Tome & Principe</option>
                        <option id="Saudi Arabia"               value="Saudi Arabia"             >Saudi Arabia</option>
                        <option id="Senegal"                    value="Senegal"                  >Senegal</option>
                        <option id="Seychelles"                 value="Seychelles"               >Seychelles</option>
                        <option id="Sierra Leone"               value="Sierra Leone"             >Sierra Leone</option>
                        <option id="Singapore"                  value="Singapore"                >Singapore</option>
                        <option id="Slovakia"                   value="Slovakia"                 >Slovakia</option>
                        <option id="Slovenia"                   value="Slovenia"                 >Slovenia</option>
                        <option id="Solomon Islands"            value="Solomon Islands"          >Solomon Islands</option>
                        <option id="Somalia"                    value="Somalia"                  >Somalia</option>
                        <option id="South Africa"               value="South Africa"             >South Africa</option>
                        <option id="Spain"                      value="Spain"                    >Spain</option>
                        <option id="Sri Lanka"                  value="Sri Lanka"                >Sri Lanka</option>
                        <option id="Sudan"                      value="Sudan"                    >Sudan</option>
                        <option id="Suriname"                   value="Suriname"                 >Suriname</option>
                        <option id="Swaziland"                  value="Swaziland"                >Swaziland</option>
                        <option id="Sweden"                     value="Sweden"                   >Sweden</option>
                        <option id="Switzerland"                value="Switzerland"              >Switzerland</option>
                        <option id="Syria"                      value="Syria"                    >Syria</option>
                        <option id="Tahiti"                     value="Tahiti"                   >Tahiti</option>
                        <option id="Taiwan"                     value="Taiwan"                   >Taiwan</option>
                        <option id="Tajikistan"                 value="Tajikistan"               >Tajikistan</option>
                        <option id="Tanzania"                   value="Tanzania"                 >Tanzania</option>
                        <option id="Thailand"                   value="Thailand"                 >Thailand</option>
                        <option id="Togo"                       value="Togo"                     >Togo</option>
                        <option id="Tokelau"                    value="Tokelau"                  >Tokelau</option>
                        <option id="Tonga"                      value="Tonga"                    >Tonga</option>
                        <option id="Trinidad & Tobago"          value="Trinidad & Tobago"        >Trinidad & Tobago</option>
                        <option id="Tunisia"                    value="Tunisia"                  >Tunisia</option>
                        <option id="Turkey"                     value="Turkey"                   >Turkey</option>
                        <option id="Turkmenistan"               value="Turkmenistan"             >Turkmenistan</option>
                        <option id="Turks & Caicos Is"          value="Turks & Caicos Is"        >Turks & Caicos Is</option>
                        <option id="Tuvalu"                     value="Tuvalu"                   >Tuvalu</option>
                        <option id="Uganda"                     value="Uganda"                   >Uganda</option>
                        <option id="United Kingdom"             value="United Kingdom"           >United Kingdom</option>
                        <option id="Ukraine"                    value="Ukraine"                  >Ukraine</option>
                        <option id="United Arab Erimates"       value="United Arab Erimates"     >United Arab Emirates</option>
                        <option id="United States of America"   value="United States of America" >United States of America</option>
                        <option id="Uraguay"                    value="Uraguay"                  >Uruguay</option>
                        <option id="Uzbekistan"                 value="Uzbekistan"               >Uzbekistan</option>
                        <option id="Vanuatu"                    value="Vanuatu"                  >Vanuatu</option>
                        <option id="Vatican City State"         value="Vatican City State"       >Vatican City State</option>
                        <option id="Venezuela"                  value="Venezuela"                >Venezuela</option>
                        <option id="Vietnam"                    value="Vietnam"                  >Vietnam</option>
                        <option id="Virgin Islands (Brit)"      value="Virgin Islands (Brit)"    >Virgin Islands (Brit)</option>
                        <option id="Virgin Islands (USA)"       value="Virgin Islands (USA)"     >Virgin Islands (USA)</option>
                        <option id="Wake Island"                value="Wake Island"              >Wake Island</option>
                        <option id="Wallis & Futana Is"         value="Wallis & Futana Is"       >Wallis & Futana Is</option>
                        <option id="Yemen"                      value="Yemen"                    >Yemen</option>
                        <option id="Zaire"                      value="Zaire"                    >Zaire</option>
                        <option id="Zambia"                     value="Zambia"                   >Zambia</option>
                        <option id="Zimbabwe"                   value="Zimbabwe"                 >Zimbabwe</option>
                     </select>

                <label style="color:snow">
                    <button class="btn add" id="submit" name="submit">Sign Up</button>
                </label>

                <a class="underline-animation" href="SignIn.aspx" style="text-align:center">already have an account?</a><br />
            </form>
               
        </fieldset>  
     </div> 
    <script src="JavaScript.js"></script> 
</asp:Content>
