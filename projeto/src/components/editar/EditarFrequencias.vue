<template>
<div>
  <div id ="add">
      <a href="#/Frequencias"><img src="../../assets/proximo.png"></a> 
  </div>
  <div id="campo">
      <label>Codigo solicitacoes</label>
      <input id="input" type="number">
  </div>
  <div id="campo">
      <label>Data verificacao</label>
      <input id="input" type="date">
  </div>
  <div id="campo">
      <label>Batimento cardiaco</label>
      <input id="input" type="number">
  </div>
  <div id="campo">
      <label>Pressao maximo</label>
      <input id="input" type="number">
  </div>
  <div id="campo">
      <label>Pressao minimo</label>
      <input id="input" type="number">
  </div>
  <div id="campo">
      <label>Sintoma</label>
      <input id="input" type="text">
  </div>
  <div id="campo">
      <label>Medicamento</label>
      <input id="input" type="text">
  </div>
</div>
</template>

<script>
</script>

<style>
 #input{
   padding: 8px;
   display: block;
   border: none;
   border-bottom: 1px solid #ccc;
   width: 98%;
  }
  #campo{
    margin: 4%;
    font-size: 20px;
  }
</style>
