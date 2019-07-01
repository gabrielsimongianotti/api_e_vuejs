<template>
<div>
  <div id ="add">
      <a href="#/Solicitacoes"><img src="../../assets/proximo.png"></a> 
  </div>
  <div id="campo">
      <label>Cartão</label>
      <input id="input" type="number">
  </div>
  <div id="campo">
      <label>Crm</label>
      <input id="input" type="number">
  </div>
  <div id="campo">
      <label>Data atendimento</label>
      <input id="input" type="date">
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
