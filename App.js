import './App.css';
import {useState} from "react";
import 'bootstrap/dist/css/bootstrap.css'

function App() {
  const[tytul,setTytul] = useState("");
  const[rodzaj, setRodzaj] = useState("")
  

  const handlePrzycisk = () => {
    console.log({tytul, rodzaj});
  };

  return (
      <div>
        <div className = "form-group">
        <label>Tytuł filmu</label>
            <input type = "text"
             id = "tytul" 
             className = "form-control"
             value = {tytul}
            onChange = {(e) => setTytul(e.target.value) }/>
        </div>
        <div className = "form-group">
        <label>Rodzaj</label>
        <select id = "rodzaj" className='form-control' value = {rodzaj} onChange = {(e) => setRodzaj(e.target.value)}>
        <option value = "0"></option>
        <option value = "1">Komedia</option>
        <option value = "2">Obyczajowy</option>
        <option value = "3">Sensacyjny</option>
        <option value = "4">Horror</option>
        </select>
        </div>
        
        <button 
        className='btn btn-primary'
        onClick = {handlePrzycisk}>Dodaj</button>

      </div>

  );  
}

export default App;
